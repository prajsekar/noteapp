using Appnote.Core.Persistence;
using Cache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp.Application
{
    public class NoteApplication
    {
        public static void bootstrapWinClient()
        {
            LocalDbBoostrap.init();
            DataStoreFactory.Instance.Key = "localDB";
        }
    }
}
