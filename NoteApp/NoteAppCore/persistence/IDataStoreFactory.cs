﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp.Core.Persistence 
{
    public interface IDataStoreFactory
    {
        IRepository getRepository();
    }
}
