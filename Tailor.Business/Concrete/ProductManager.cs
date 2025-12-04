using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tailor.Business.Abstract;
using Tailor.DataAccess.Abstract;
using Tailor.DTO.DTOs.ProductDtos;
using Tailor.Entity.Entities;
using Tailor.Entity.Entities.Enums;

namespace Tailor.Business.Concrete
{
    public class ProductManager : GenericManager<Product>, IProductService
    {
        private readonly IProductDal _productDal;
        private readonly IMapper _mapper;

        // Constructor Injection: Hem DAL'a hem Mapper'a ihtiyacımız var.
        public ProductManager(IProductDal productDal, IMapper mapper) : base(productDal)
        {
            _productDal = productDal;
            _mapper = mapper;
        }

        // =========================================================================
        // 1. MEVCUT METOTLAR (CRUD ve Detay)
        // =========================================================================

        public void CreateProduct(CreateProductDto createProductDto)
        {
            var product = _mapper.Map<Product>(createProductDto);

            // Kumaş ve Kıyafet ayrımı (Kritik İş Mantığı)
            if (product.ProductType == ProductType.Fabric)
            {
                // Kumaş ise: Varyant olamaz, Ana Stok tablosuna yazılır.
                if (product.Stock == null) product.Stock = new Stock();
                // Not: Quantity bilgisi DTO'da mapping ile Stock içine taşınmış olmalı
                // veya burada manuel atanmalı: product.Stock.Quantity = ... 
                // --- HATA ÇÖZÜMÜ BURADA ---
                // Veritabanı Location alanını zorunlu tutuyor, boş geçemeyiz.
                product.Stock.Location = "Merkez Depo"; // Varsayılan bir yer atıyoruz.

                // Eğer DTO'dan gelen stok miktarı Mapping ile dolmadıysa, manuel atayalım:
                // (CreateProductDto içinde 'TotalStockQuantity' adında bir alan olduğunu varsayıyorum)
                // product.Stock.Quantity = createProductDto.TotalStockQuantity;
                product.ProductVariants = null;
            }
            else if (product.ProductType == ProductType.ReadyToWear)
            {
                // Kıyafet ise: Ana Stok tablosu boştur, Varyantlar (Bedenler) doludur.
                product.Stock = null;
                if (product.ProductVariants == null || !product.ProductVariants.Any())
                {
                    throw new Exception("Kıyafet eklerken en az bir beden/varyant girmelisiniz.");
                }
            }

            // Oluşturulma tarihini otomatik atayalım
            product.CretaedAt = DateTime.Now;

            try
            {
                _productDal.Add(product);
            }
            catch (Exception ex)
            {
                // Hatanın kök nedenini yakalayıp ekrana basacağız
                string detay = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                throw new Exception($"VERİTABANI HATASI: {detay}");
            }
        }

        public List<ResultProductListDto> GetProductsWithCategory()
        {
            // Kategorisiyle beraber tüm ürünleri çek
            var values = _productDal.GetListWithRelations(null, "Category");
            return _mapper.Map<List<ResultProductListDto>>(values);
        }

        public ResultProductDto GetProductDetailsById(int id)
        {
            // Detay sayfasında her şeye ihtiyacımız var (Include zinciri)
            var product = _productDal.GetListWithRelations(
                x => x.id == id,
                "Category",
                "Stock",
                "ProductVariants",
                "ProductProperty",
                "ProductTags.Tag" // Çoka-çok ilişki detayına inme
            ).FirstOrDefault();

            if (product == null) return null;

            return _mapper.Map<ResultProductDto>(product);
        }

        // =========================================================================
        // 2. ARAMA VE FİLTRELEME
        // =========================================================================

        public List<ResultProductListDto> SearchProducts(string keyword)
        {
            // İsimde VEYA Açıklamada aranan kelime geçiyorsa getir (Case insensitive genelde veritabanı ayarına bağlıdır)
            var values = _productDal.GetListByFilter(x =>
                x.Name.Contains(keyword) ||
                x.Description.Contains(keyword)
            );

            return _mapper.Map<List<ResultProductListDto>>(values);
        }

        public List<ResultProductListDto> GetProductsByPriceRange(decimal minPrice, decimal maxPrice)
        {
            // Belirli fiyat aralığındaki ürünler
            var values = _productDal.GetListByFilter(x => x.price >= minPrice && x.price <= maxPrice);
            return _mapper.Map<List<ResultProductListDto>>(values);
        }

        public List<ResultProductListDto> GetProductsByType(ProductType productType)
        {
            // Sadece Kumaşları veya Sadece Kıyafetleri getir
            var values = _productDal.GetListWithRelations(x => x.ProductType == productType, "Category");
            return _mapper.Map<List<ResultProductListDto>>(values);
        }

        // =========================================================================
        // 3. VİTRİN VE ÖNE ÇIKANLAR
        // =========================================================================

        public List<ResultProductListDto> GetLastAddedProducts(int count)
        {
            // Generic DAL'da OrderBy metodu olmadığı için veriyi çekip bellekte sıralıyoruz.
            // (Performans notu: İlerde DAL'a GetLastItems metodu eklenebilir)
            var values = _productDal.GetListWithRelations(null, "Category")
                .OrderByDescending(x => x.CretaedAt)
                .Take(count)
                .ToList();

            return _mapper.Map<List<ResultProductListDto>>(values);
        }

        public List<ResultProductListDto> GetShowcaseProducts(DisplayType displayType)
        {
            // İlişkili tablodan (ProductDisplay) sorgulama yapıyoruz.
            // "Bana öyle ürünleri getir ki, ProductDisplays listesinde 'displayType' eşleşen bir kayıt olsun."
            var values = _productDal.GetListWithRelations(
                x => x.ProductDisplays.Any(pd => pd.DisplayType == displayType),
                "Category"
            );

            return _mapper.Map<List<ResultProductListDto>>(values);
        }

        // =========================================================================
        // 4. PERFORMANS VE SAYFALAMA
        // =========================================================================

        public List<ResultProductListDto> GetProductsWithPaging(int page, int size)
        {
            // Sayfa 1: İlk 12 ürün (Skip 0, Take 12)
            // Sayfa 2: Sonraki 12 ürün (Skip 12, Take 12)
            var values = _productDal.GetListWithRelations(null, "Category")
                .Skip((page - 1) * size)
                .Take(size)
                .ToList();

            return _mapper.Map<List<ResultProductListDto>>(values);
        }

        // =========================================================================
        // 5. ADMİN / YÖNETİM METOTLARI
        // =========================================================================

        public void UpdateStock(int productId, decimal newQuantity)
        {
            var product = _productDal.GetListWithRelations(x => x.id == productId, "Stock").FirstOrDefault();

            if (product != null)
            {
                if (product.ProductType == ProductType.Fabric)
                {
                    // Kumaş ise ana stoğu güncelle
                    if (product.Stock != null)
                    {
                        product.Stock.Quantity = newQuantity;
                        _productDal.Update(product); // Cascade update yapar
                    }
                }
                else
                {
                    // Kıyafet ise bu metot çalışmaz, çünkü hangi bedenin (varyantın) güncelleneceğini bilmiyoruz.
                    throw new InvalidOperationException("Kıyafet stoğu güncellemek için Varyant ID'si gereklidir.");
                }
            }
        }

        public void ToggleProductStatus(int id)
        {
            var product = _productDal.GetById(id);
            if (product != null)
            {
                // Aktifse Pasif, Pasifse Aktif yap (Tersine çevir)
                product.IsActive = !product.IsActive;
                _productDal.Update(product);
            }
        }
    }
}
