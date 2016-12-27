using NoteApp.Core.Persistence;
using Cache;
using NoteApp.Core.Model.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoteMVP.Presenter;

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
            var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            LocalDbBoostrap.registerDataStore(appDataPath + @"\remoteNoteDb.sdf", "remoteDB");
        }
    }
}
