using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tailor.DTO.DTOs.BannerDtos;
using Tailor.Entity.Entities;

namespace Tailor.Business.Abstract
{
    public interface IBannerService : IGenericService<Banner>
    {
        /// <summary>
        /// Tüm bannerları getirir, isteğe bağlı olarak sadece aktif olanları filtreler
        /// </summary>
        List<ResultBannerDto> GetAllBanners(bool onlyActive = false);

        /// <summary>
        /// ID'ye göre banner getirir
        /// </summary>
        ResultBannerDto GetBannerById(int id);

        /// <summary>
        /// Yeni banner oluşturur ve resim dosyasını kaydeder
        /// </summary>
        void CreateBanner(CreateBannerDto dto, IFormFile imageFile);

        /// <summary>
        /// Mevcut banner'ı günceller, resim dosyası opsiyoneldir
        /// </summary>
        void UpdateBanner(int id, UpdateBannerDto dto, IFormFile imageFile = null);

        /// <summary>
        /// Banner'ı siler ve ilişkili resim dosyasını kaldırır
        /// </summary>
        void DeleteBanner(int id);
    }
}
