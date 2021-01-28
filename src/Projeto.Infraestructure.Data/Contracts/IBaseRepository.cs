using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Projeto.Infraestructure.Data.Contracts
{
    public interface IBaseRepository<TEntity> : IDisposable where TEntity : class
    {
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        void SaveChanges();
        List<TEntity> FindAll();
        List<TEntity> Find(Expression<Func<TEntity, bool>> expression);
        TEntity FindById(Guid id);
        int Count();
    }
}
