using Appnote.Core.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp.Core.Model.Service
{
    public abstract class DataService<T,K> : IDataService<T,K> where T : class
    {
        protected String key;
        
        public DataService(String key)
        {
            this.key = key;
        }
        
        public T add(T obj)
        {
            T result = null;
            using (var ctx = DataStoreFactory.Instance.getRepository(key))
            {
                result = ctx.add<T>(obj);
            }
            return result;
        }
      
        public T get(K key)
        {
            T result = null;
            using (var ctx = DataStoreFactory.Instance.getRepository(key))
            {
                result = ctx.get<T,K>(key);
            }
            return result;
        }

        public void delete(K key)
        {
            using (var ctx = DataStoreFactory.Instance.getRepository(key))
            {
               ctx.delete<T, K>(key);
            }
        }

        public abstract void update(T obj);
    }
}
