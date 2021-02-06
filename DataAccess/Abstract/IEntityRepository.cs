using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //public interface IEntityRepository<T> : Kısılama olmaksızın T tipinde tanımlama
    //Generic constraint : genel tür kısıtlaması 
    //class : referans olabilir
    //IEntity: IEntity olabilir ya da IEntity implemente eden bir nesne olabilir.
    //new(): new lenebilir olmalı (interfaceler new lenemediği için IEntity olamaz artık)
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}

