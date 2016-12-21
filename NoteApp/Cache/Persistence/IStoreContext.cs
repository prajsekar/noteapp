using Cache.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cache.Persistence
{
    interface IStoreContext
    {
        IRepository getRepository();
    }
}
