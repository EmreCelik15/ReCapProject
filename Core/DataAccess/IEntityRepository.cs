using Core.Entities;//Bu Core.Entities olmalıydı.Neden olmadı araştır.
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess//Core katmanı diğer katmanları referans almaz.
{
    //Generic Constrain
    //IEntity:IEntity olabilir ya da IEntity' i implemente eden nesne olabilir.
    public interface IEntityRepository<T> where T:class, IEntity,new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);//filter=null filtre vermeyedebilirsin demek
        T Get(Expression<Func<T, bool>> filter);//filter zorunlu demek
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
