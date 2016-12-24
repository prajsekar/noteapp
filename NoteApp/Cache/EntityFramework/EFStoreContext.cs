using Cache.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Appnote.Core.Persistence;

namespace Cache.EntityFramework
{
    class EFStoreContext : IDataStoreFactory
    {
        public static String connectionString { get; set; }

        static EFStoreContext()
        {
            connectionString = @"data source= C:\Users\rajasekarp\AppData\Roaming\notestore.sdf";
        }

        public IRepository getRepository()
        {
            return new NoteDB(connectionString);   
        }
    }
}
