using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appnote.Core.Model
{
    public interface IUpdateTimeRequired
    {
        void updateCreationTime(long time);
        void updateModifiedTime(long time);
    }
}
