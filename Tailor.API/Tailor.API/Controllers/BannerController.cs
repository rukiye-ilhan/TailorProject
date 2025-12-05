using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tailor.Business.Abstract;
using Tailor.DTO.DTOs.BannerDtos;

namespace Tailor.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BannerController : ControllerBase
    {
        private readonly IBannerService _bannerService;

        public BannerController(IBannerService bannerService)
        {
            _bannerService = bannerService;
        }

        // =========================================================================
        // GET: api/banner
        // Tüm bannerları getirir, ?onlyActive=true ile sadece aktif olanlar
        // =========================================================================
        [HttpGet]
        public IActionResult GetAll([FromQuery] bool onlyActive = false)
        {
            try
            {
                var banners = _bannerService.GetAllBanners(onlyActive);
                return Ok(banners);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // =========================================================================
        // GET: api/banner/{id}
        // ID'ye göre banner getirir
        // =========================================================================
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var banner = _bannerService.GetBannerById(id);
                if (banner == null)
                {
                    return NotFound($"ID {id} ile banner bulunamadı.");
                }
                return Ok(banner);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // =========================================================================
        // POST: api/banner
        // Yeni banner oluşturur (form-data + image)
        // =========================================================================
        [HttpPost]
        public IActionResult Create([FromForm] CreateBannerDto createDto, [FromForm] IFormFile imageFile)
        {
            try
            {
                // Validasyon
                if (string.IsNullOrWhiteSpace(createDto.Title))
                {
                    return BadRequest("Başlık alanı zorunludur.");
                }

                if (imageFile == null || imageFile.Length == 0)
                {
                    return BadRequest("Resim dosyası zorunludur.");
                }

                // Dosya uzantısı kontrolü
                var allowedExtensions = new[] { ".jpg", ".jpeg", ".png", ".gif", ".webp" };
                var extension = Path.GetExtension(imageFile.FileName).ToLowerInvariant();
                if (!allowedExtensions.Contains(extension))
                {
                    return BadRequest("Sadece resim dosyaları yüklenebilir (.jpg, .jpeg, .png, .gif, .webp).");
                }

                // Dosya boyutu kontrolü (5MB)
                if (imageFile.Length > 5 * 1024 * 1024)
                {
                    return BadRequest("Resim dosyası 5MB'dan büyük olamaz.");
                }

                _bannerService.CreateBanner(createDto, imageFile);
                return StatusCode(201, "Banner başarıyla oluşturuldu.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // =========================================================================
        // PUT: api/banner/{id}
        // Mevcut banner'ı günceller (image opsiyonel)
        // =========================================================================
        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromForm] UpdateBannerDto updateDto, [FromForm] IFormFile imageFile = null)
        {
            try
            {
                // Validasyon
                if (string.IsNullOrWhiteSpace(updateDto.Title))
                {
                    return BadRequest("Başlık alanı zorunludur.");
                }

                // Eğer yeni resim yüklendiyse validasyon yap
                if (imageFile != null && imageFile.Length > 0)
                {
                    var allowedExtensions = new[] { ".jpg", ".jpeg", ".png", ".gif", ".webp" };
                    var extension = Path.GetExtension(imageFile.FileName).ToLowerInvariant();
                    if (!allowedExtensions.Contains(extension))
                    {
                        return BadRequest("Sadece resim dosyaları yüklenebilir (.jpg, .jpeg, .png, .gif, .webp).");
                    }

                    if (imageFile.Length > 5 * 1024 * 1024)
                    {
                        return BadRequest("Resim dosyası 5MB'dan büyük olamaz.");
                    }
                }

                _bannerService.UpdateBanner(id, updateDto, imageFile);
                return NoContent(); // 204 No Content
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // =========================================================================
        // DELETE: api/banner/{id}
        // Banner'ı siler
        // =========================================================================
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _bannerService.DeleteBanner(id);
                return NoContent(); // 204 No Content
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
