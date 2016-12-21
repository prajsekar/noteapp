using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cache.Entity
{
    interface IUpdateTimeRequired
    {
        void updateCreationTime(long time);
        void updateModifiedTime(long time);
    }
}
