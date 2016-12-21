using CacheCodeFirst.EntityFramework;
using Cache.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cache.Persistence
{
    public class DataStoreFactory    {        
        public static IRepository getRepository()
        {
            return new EFStoreContext().getRepository(); 
        }
    }
}
