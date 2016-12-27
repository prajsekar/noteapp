using NoteApp.Core.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp.Core.Model.Service
{
    public abstract class DataService<T,K> : IDataService<T,K> where T : class
    {
        protected String repoKey;
        
        public DataService(String key)
        {
            this.repoKey = key;
        }
        
        virtual public T add(T obj)
        {
            T result = null;
            using (var ctx = DataStoreFactory.Instance.getRepository(repoKey))
            {
                result = ctx.add<T>(obj);
            }
            return result;
        }
      
        virtual public T get(K key)
        {
            T result = null;
            using (var ctx = DataStoreFactory.Instance.getRepository(repoKey))
            {
                result = ctx.get<T,K>(key);
            }
            return result;
        }

        virtual public void delete(K key)
        {
            using (var ctx = DataStoreFactory.Instance.getRepository(repoKey))
            {
               ctx.delete<T, K>(key);
            }
        }

        public abstract void update(T obj);
    }
}
