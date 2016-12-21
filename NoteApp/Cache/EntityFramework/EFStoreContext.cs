using Cache.Persistence;
using Cache.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacheCodeFirst.EntityFramework
{
    class EFStoreContext : IStoreContext
    {
        public static String connectionString { get; set; }

        static EFStoreContext()
        {
            connectionString = @"data source= C:\Users\rajasekarp\AppData\Roaming\notestore.sdf";
        }

        public Cache.Persistence.IRepository getRepository()
        {
            return new NoteDB(connectionString);   
        }
    }
}
