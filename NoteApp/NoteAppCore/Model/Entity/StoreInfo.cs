using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appnote.Core.Model.Entity 
{
    public partial class StoreInfo
    {
        public int Id { get; set; }
        public long lastSynced { get; set; }
        public long lastOffline { get; set; }
    }
}
