using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Appnote.Core.Persistence
{
    public interface IRepository : IDisposable, IRepositoryAsync
    {
        T add<T>(T obj) where T : class;
        void update<T>(T obj, params Expression<Func<T, object>>[] propertiesToUpdate) where T : class;
        void delete<T, K>(K key) where T : class;
        T get<T, K>(K id) where T : class;
        IQueryable<T> getDataSet<T>() where T : class;
    }
}
