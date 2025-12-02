using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tailor.Entity.Entities
{
    /*Birincil anahtar bir tablodaki her sütünu benzersiz bir şekilde tanımlayan bir veya daha fazla sütundur.kritik nokta her satırın eşsiz olmasını sağlar
     * çoğu tabloda id tek bir sütün birincil anahtar olarak kullanılır. örneğin products tablosundaki her ürün benzersiz bir productId ile tanımlanır
     * Bileşik birincil anahtar(Composite Primary key) bazı durumlarda bir satırı benzersiz yapmak için birden fazla sütünun birleşimi gerekir
     *ProductTag sınıfıda tam olarak bu duruma bir örnektir.çünkü bir ürünün birden fazla etiketi olabilir ve bir etiket birden fazla ürüne uygulanabilir.
     *Amaç, her ürün-etiket kombinasyonunun benzersiz olmasını sağlamaktır.Bu nedenle ProductId ve TagId birlikte bileşik birincil anahtar olarak kullanılır ve aynı zamanda Eğer ProductID = 101 ve TagID = 1 değerlerinin birleşimini birincil anahtar yaparsak, aynı ürünün aynı etikete birden fazla kez eklenmesini engellemiş oluruz.
     */

    public class ProductTag
    {
        //Birincil anahtar olatak bu iki id'nin kombinasyonu kullanılabilir
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int TagId { get; set; }
        public Tag Tag { get; set; }

    }
}
