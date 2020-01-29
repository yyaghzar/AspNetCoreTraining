using AspNetCoreTraining.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreTraining.Data.Repos
{
    public interface IRepo<TEntity> where TEntity : class,IEntity
    {
        Task<List<TEntity>> GetAll();
        Task<TEntity> Get(int id);
        Task<TEntity> Add(TEntity entity);
        Task<TEntity> Update(TEntity entity);
        Task<TEntity> Delete(int id);
    }
}
