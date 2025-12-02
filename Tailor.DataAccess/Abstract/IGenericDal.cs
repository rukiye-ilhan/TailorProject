using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Tailor.DataAccess.Abstract
{
    public interface IGenericDal<T> where T : class
    {
            //Temel CRUD operasyonları
            void Add(T entity);
            void Update(T entity);
            void Delete(T entity);
            List<T> GetAll();
            T GetById(int id);

        //Filtreli listeleme: tümünü değil sadece şarta uyanları getir
        //Örn: GetListByFilter(x => x.Price > 100 && x.IsActive == true);
        List<T> GetListByFilter(Expression<Func<T, bool>> filter);

        // tekil filtreleme  ıd dışında başka bir şeye göre tek kayıt getirir
        //örn GetByFilter(x => x.Email == "musteri@mail.com");
        T GetByFilter(Expression<Func<T, bool>> filter);
        //TOP 1 sorguusu. ilk kaydı bulduğu an armayı durdurur
        T GetByFilter1(Expression<Func<T, bool>> filter);

        //3.Olarak ilişkili veri getirme ürünleri getiriken kategorisini ve resimlerini de doldurarak getirir
        List<T> GetListWithRelations(Expression<Func<T, bool>> filter = null, params string[] includeProperties);




    }
}
