using Cache.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoteApp.Core.Persistence;
using System.IO;

namespace Cache.EntityFramework
{
    class EFStoreContext : IDataStoreFactory
    {
        public String connectionString { get; set;}

        public EFStoreContext()
        {
            init(null);
        }

        public EFStoreContext(String connectionString) 
        {  
            init(connectionString);
        }

        private void init(String connectionString) 
        {
            if (String.IsNullOrEmpty(connectionString))
            {
                var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                this.connectionString = appDataPath + @"\notestore.sdf";                
            }
            else
            {
                this.connectionString = connectionString;
            }
        }

        public IRepository getRepository()
        {
            return new NoteDB(connectionString);   
        }
    }
}
