using NoteApp.Core.Model.Entity;
using NoteApp.Core.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp.Core.Model
{
    public class SyncInfoRepo 
    {
        private String storeKey;
        private StoreInfo storeInfo;
        public SyncInfoRepo(String storeKey)
        {
            this.storeKey = storeKey;
            validateRecord();
        }
        
        public long LastSyncTime
        {
            get
            {
                using (var ctx = DataStoreFactory.Instance.getRepository(storeKey))
                {
                    storeInfo = ctx.get<StoreInfo, int>(storeInfo.Id);
                }
                return storeInfo.lastSynced;
            }
            set
            {
                Console.WriteLine("Persisting sync time to db");
                storeInfo.lastSynced = value;
                using (var ctx = DataStoreFactory.Instance.getRepository(storeKey))
                {
                    ctx.update<StoreInfo>(storeInfo, s => s.lastSynced);
                }     
            }
        }

        public long LastOfflineTime
        {
            get
            {
                using (var ctx = DataStoreFactory.Instance.getRepository(storeKey))
                {
                    storeInfo = ctx.get<StoreInfo, int>(storeInfo.Id);
                }
                return storeInfo.lastOffline;
            }
            set
            {
                Console.WriteLine("Persisting last time to db");
                storeInfo.lastOffline = value;
                using (var ctx = DataStoreFactory.Instance.getRepository(storeKey))
                {
                    ctx.update<StoreInfo>(storeInfo, s => s.lastOffline);
                }                
            }
        }

        private void validateRecord()
        {
            using (var ctx = DataStoreFactory.Instance.getRepository(storeKey))
            {
                try{
                    var record = ctx.getDataSet<StoreInfo>().FirstOrDefault<StoreInfo>();
                    if (record == null)
                    {
                        record = ctx.add<StoreInfo>(new StoreInfo() { lastSynced = -1, lastOffline = -1 });
                    }
                    storeInfo = record;
                }catch(Exception) {
                    Console.WriteLine("No store info record found");
                }
            }     
        }
    }
}
