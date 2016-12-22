using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cache.Persistence
{
    public interface IRepositoryAsync : IDisposable
    {
        Task<T> getAsync<T, K>(K id) where T: class;
        Task<T> updateAsync<T>(T obj, params Expression<Func<T, object>>[] propertiesToUpdate) where T : class;
        Task<T> deleteAsync<T>(T obj) where T : class;
        Task<IQueryable<T>> getDatasetAsync<T>() where T : class;
        Task<T> addAsync<T>(T obj) where T : class;
    }
}
