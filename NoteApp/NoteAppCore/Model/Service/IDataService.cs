using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp.Core.Model.Service
{
    public interface IDataService<T, K>
    {
        T add(T obj);
        void update(T obj);
        T get(K key);
        void delete(K key);       
    }
}
