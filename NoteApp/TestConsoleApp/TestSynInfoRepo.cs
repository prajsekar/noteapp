using NoteApp.Core.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoteApp.Core.Model;

namespace TestConsoleApp
{
    public class TestSyncInfoRepo
    {
        public static void TestRecordValidation() 
        {
            SyncInfoRepo repo = new SyncInfoRepo("localDB");
            var lastSynced = repo.LastSyncTime;
            Console.WriteLine("last synced : {0}", lastSynced);
            Console.Read();
        }
    }
}
