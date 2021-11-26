using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.InMemory
{
    public class InMemoryRepositoryBase<TEntity> : IInMemoryRepository<TEntity> where TEntity : class, IEntity, new()
    {
        public void Add(TEntity entity)
        {

           
            throw new NotImplementedException();
        }

        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public List<TEntity> Get(int userId)
        {
            throw new NotImplementedException();
        }

        public List<TEntity> Getall()
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }

        TEntity IInMemoryRepository<TEntity>.Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
