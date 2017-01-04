using NoteApp.Core.Persistence;
using Cache;
using NoteApp.Core.Model.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoteMVP.Presenter;
using NoteApp.Sync;

namespace NoteApp.Application
{
    public class NoteApplication
    {
        public static void bootstrapWinClient(bool mock = false)
        {
            if (mock)
            {
                NoteAppPresenter.PresenterTypeKey = "noSync";
                NoteAppService.RepositoryKey = "remoteDB";
            }
            else
            {
                NoteAppService.RepositoryKey = "localDB";    
            }
            
            //Register local data base
            LocalDbBoostrap.registerDataStore();
            DataStoreFactory.Instance.Key = "localDB";

            //Register mock remote database
            var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            LocalDbBoostrap.registerDataStore(appDataPath + @"\remoteNoteDb.sdf", "remoteDB");
        }

        public static INoteAppService GetService(bool mock = false)
        {
            var result  = mock == false ?
               new SyncService("localDB", new NoteAppService("remoteDB"), null, SyncService.SyncMode.TwoWay) :
               new SyncService("remoteDB", new NoteAppService("remoteDB"), null, SyncService.SyncMode.OneWay);
            return result;
        }

        public static INoteAppService GetService_onlyLocal(bool mock = false)
        {
            return new NoteAppService();            
        }
    }
}
