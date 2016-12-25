using Appnote.Core.Persistence;
using Cache;
using NoteApp.Core.Model.Service;
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
            NoteAppService.RepositoryKey = "localDB";
            //Register local data base
            LocalDbBoostrap.registerDataStore();
            DataStoreFactory.Instance.Key = "localDB";

            //Register mock remote database
            var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            LocalDbBoostrap.registerDataStore(appDataPath + @"\remoteNoteDb.sdf", "remoteDB");
        }
    }
}
