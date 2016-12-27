using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sync
{
    public interface ISyncProcessor
    {
        void Process(SyncEvent syncEvent);
        void Init();
        void DeInit();
    }
}
