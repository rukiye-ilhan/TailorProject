using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tailor.Entity.Entities
{
    public class Category
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string  ImageUrl { get; set; }
       //kendi Kendine referans kendi içinde parent child ilişkisi self referancing relationship
       public int? ParentCategoryId { get; set; } //nullable bull olarak bırakılabilir hata sebebi olmaz
        public Category ParentCategory { get; set; }
        public ICollection<Category> ChildCategories { get; set; } //birden fazla child olabilir ChildCategories = SubCategories birden fazla alt kategori olabilir

        //Bir kategorinin birden fazla ürünü olabilir ancak bir ürün yalnızca bir ana kategoriye ait olabilir bu yüzden aralarında bire çok ilişkisi vardır.
        //bir ürün doğrudan  birden fazla alt kategoriye sahip olamaz her bir alt kategori yalınza bir üst kategoriye ait olabilir
        //bir ürün hem elbise hem mevsimlik kategorisene sahip olabiiir ancak uunique değerlerle tutulan ıdler üzeridenn tek bir tabloda bu ürünü aynı anda hem elbise heem mevsimlik gibi iki farklı kategoriye doğrudan bağlanılamaz.
        //Birden fazla alt kategoriye sahip olması için junction table dediğimiz ara tablo kullanmamız gerekir.ya da product propertysi ile çözüm .Product ve ProductCategory arasında bire-çok ilişki kurulur
        /*Bir ürün, kategori ağacında tek bir "yer"e sahip olmalıdır. Ancak, ürünün birden fazla alt kategori gibi davranmasını istiyorsanız, bunu çoka-çok ilişkisi kurarak etiketler veya özellikler aracılığıyla yapmalısınız. Bu, veritabanı tasarımınızı daha esnek ve güçlü hale getirecektir. */
        //Navigation property
        public ICollection<Product> Prodacts { get; set; }

        // --- EKSİK OLAN SATIR BU ---
        // Bir kategorinin hangi bloglarda kullanıldığını tutan liste:
        public ICollection<BlogCategoryAssignment> CategoryAssignments { get; set; }
    }
}
