using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tailor.DTO.DTOs.ShoppingCartItem;

namespace Tailor.DTO.DTOs.ShoppingCardDtos
{
    // RESULT (Sepetin Tamamını Gösterme)
    public class ResultShoppingCartDto
    {
        public int ShoppingCartId { get; set; }

        // Sepetin kime ait olduğu (Anonim veya Üye)
        public int? UserId { get; set; }

        // Sepetteki ürünlerin listesi
        public List<ResultCartItemDto> Items { get; set; }

        // Sepet Toplam Tutarı (Items listesindeki TotalPrice'ların toplamı)
        public decimal GrandTotal { get; set; }
    }
}
/*
 * Neden Bu Şekilde Tasarladık?
Fiyat Güvenliği (AddCartItemDto): Kullanıcıdan asla Price bilgisi almayız. Kullanıcı sadece ProductId gönderir, sistem güncel fiyatı veritabanından çeker. Aksi takdirde kullanıcı 1000 TL'lik ürünü 1 TL olarak sepete atabilir.

Veri Düzleştirme (ResultCartItemDto): Sepeti görüntülerken ürünün adına ve resmine ihtiyacımız var. Frontend'in tekrar tekrar ürün sorgusu atmasını engellemek için bu bilgileri ProductName ve ProductImageUrl olarak DTO'ya ekledik.

Hesaplanmış Alanlar (GrandTotal): Sepet toplamı veritabanında saklanmaz (genellikle), anlık olarak hesaplanır. DTO, bu hesaplanmış veriyi taşımak için mükemmel bir yerdir.
 */