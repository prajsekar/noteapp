using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sync
{
    public enum SourceType
    {
        User,
        Notebook,
        Note
    }

    public class SyncEvent
    {
        public SourceType sourceType { get; set; }
        public String data { get; set; }        
    }
}
