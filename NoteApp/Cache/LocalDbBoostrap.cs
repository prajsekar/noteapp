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
        public static bool init()
        {
            var result = true;
            try
            {
                DataStoreFactory.Instance.register("localDB", new EFStoreContext());
                DataStoreFactory.Instance.Key = "localDB";
            }
            catch (Exception ex)
            {
                Trace.WriteLine(String.Format("Error bootstraping  localDB error : {0}, stackTrace : {1}", ex.Message, ex.StackTrace));
            }
            return result;
        }
    }
}
