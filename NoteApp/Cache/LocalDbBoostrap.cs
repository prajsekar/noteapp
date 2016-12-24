using Appnote.Core.Persistence;
using Cache.EntityFramework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cache
{
    public class LocalDbBoostrap
    {
        public static bool registerDataStore(String connectionString = null, String key = null)
        {
            var result = true;
            try
            {
                key = key ?? "localDB";
                var storeFactory = new EFStoreContext(connectionString);
                DataStoreFactory.Instance.register(key, storeFactory);
            }
            catch (Exception ex)
            {
                Trace.WriteLine(String.Format("Error bootstraping  localDB error : {0}, stackTrace : {1}", ex.Message, ex.StackTrace));
            }
            return result;
        }

    }
}
