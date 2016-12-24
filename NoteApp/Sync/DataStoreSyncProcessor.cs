using NoteApp.Core.Model.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sync
{
    class DataStoreSyncProcessor : ISyncProcessor
    {
        private INoteAppService service;
        public DataStoreSyncProcessor(INoteAppService service)
        {
            this.service = service;
        }

        public void Process(SyncEvent syncEvent)
        {
            throw new NotImplementedException();
        }

        public void Init()
        {
            throw new NotImplementedException();
        }

        public void DeInit()
        {
            throw new NotImplementedException();
        }
    }
}
