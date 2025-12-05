using AutoMapper;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tailor.Business.Abstract;
using Tailor.DataAccess.Abstract;
using Tailor.DTO.DTOs.BannerDtos;
using Tailor.Entity.Entities;

namespace Tailor.Business.Concrete
{
    public class BannerManager : GenericManager<Banner>, IBannerService
    {
        private readonly IBannerDal _bannerDal;
        private readonly IMapper _mapper;
        private readonly string _uploadsFolder = "wwwroot/uploads/banners";

        public BannerManager(IBannerDal bannerDal, IMapper mapper) : base(bannerDal)
        {
            _bannerDal = bannerDal;
            _mapper = mapper;
        }

        public List<ResultBannerDto> GetAllBanners(bool onlyActive = false)
        {
            List<Banner> banners;

            if (onlyActive)
            {
                banners = _bannerDal.GetListByFilter(b => b.IsActive);
            }
            else
            {
                banners = _bannerDal.GetAll();
            }

            return _mapper.Map<List<ResultBannerDto>>(banners);
        }

        public ResultBannerDto GetBannerById(int id)
        {
            var banner = _bannerDal.GetById(id);
            if (banner == null)
            {
                return null;
            }

            return _mapper.Map<ResultBannerDto>(banner);
        }

        public void CreateBanner(CreateBannerDto dto, IFormFile imageFile)
        {
            if (imageFile == null || imageFile.Length == 0)
            {
                throw new ArgumentException("Resim dosyası zorunludur.");
            }

            // Resmi kaydet ve path al
            string imagePath = SaveImage(imageFile);

            // DTO'dan Entity'e map
            var banner = _mapper.Map<Banner>(dto);
            banner.ImagePath = imagePath;
            banner.CreatedAt = DateTime.Now;
            banner.UpdatedAt = DateTime.Now;

            _bannerDal.Add(banner);
        }

        public void UpdateBanner(int id, UpdateBannerDto dto, IFormFile imageFile = null)
        {
            var existingBanner = _bannerDal.GetById(id);
            if (existingBanner == null)
            {
                throw new KeyNotFoundException($"ID {id} ile banner bulunamadı.");
            }

            // Eğer yeni resim yüklendiyse, eski resmi sil ve yenisini kaydet
            if (imageFile != null && imageFile.Length > 0)
            {
                DeleteImageFile(existingBanner.ImagePath);
                existingBanner.ImagePath = SaveImage(imageFile);
            }

            // DTO'dan gelen değerleri mevcut entity'e map et
            existingBanner.Title = dto.Title;
            existingBanner.Description = dto.Description;
            existingBanner.IsActive = dto.IsActive;
            existingBanner.UpdatedAt = DateTime.Now;

            _bannerDal.Update(existingBanner);
        }

        public void DeleteBanner(int id)
        {
            var banner = _bannerDal.GetById(id);
            if (banner == null)
            {
                throw new KeyNotFoundException($"ID {id} ile banner bulunamadı.");
            }

            // Resim dosyasını sil
            DeleteImageFile(banner.ImagePath);

            _bannerDal.Delete(banner);
        }

        // =========================================================================
        // YARDIMCI METOTLAR (Image Upload/Delete)
        // =========================================================================

        /// <summary>
        /// Resim dosyasını wwwroot/uploads/banners/ içine GUID ile kaydeder
        /// </summary>
        private string SaveImage(IFormFile imageFile)
        {
            // Uploads klasörünü oluştur (yoksa)
            if (!Directory.Exists(_uploadsFolder))
            {
                Directory.CreateDirectory(_uploadsFolder);
            }

            // Dosya uzantısını al
            string extension = Path.GetExtension(imageFile.FileName);

            // GUID ile benzersiz dosya adı oluştur
            string fileName = $"{Guid.NewGuid()}{extension}";

            // Tam dosya yolu
            string filePath = Path.Combine(_uploadsFolder, fileName);

            // Dosyayı kaydet
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                imageFile.CopyTo(stream);
            }

            // Veritabanına kaydedilecek relative path (web'den erişilebilir)
            return $"/uploads/banners/{fileName}";
        }

        /// <summary>
        /// Verilen path'teki resim dosyasını siler
        /// </summary>
        private void DeleteImageFile(string imagePath)
        {
            if (string.IsNullOrEmpty(imagePath))
            {
                return;
            }

            // Relative path'i fiziksel path'e çevir
            // imagePath: "/uploads/banners/abc.jpg" -> "wwwroot/uploads/banners/abc.jpg"
            string physicalPath = Path.Combine("wwwroot", imagePath.TrimStart('/'));

            if (File.Exists(physicalPath))
            {
                File.Delete(physicalPath);
            }
        }
    }
}
