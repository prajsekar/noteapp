﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp.Core.Persistence 
{
    public class DataStoreFactory    {
        static DataStoreFactory()
        {
            Instance = new DataStoreFactory();
        }
        private Dictionary<String, IDataStoreFactory> factoryMap = new Dictionary<string,IDataStoreFactory>();
        public String Key { private get; set;}
        
        public void register(String key, IDataStoreFactory factory)
        {
            try
            {
                if (factory != null)
                {
                    factoryMap.Add(key, factory);
                }
            }
            catch (ArgumentException)
            {
                //Ignore any exception
            }
        }

        //Returns repository impl
        public IRepository getRepository(String key)
        {            
            IRepository result = null;
            if (!String.IsNullOrEmpty(Key))
            {

                IDataStoreFactory factory = null;
                if (factoryMap.TryGetValue(key, out factory) == true)
                {
                    result = factory.getRepository();
                }
            }
            else
            {
                Trace.Write("Unable data store factory key is null or empty");
            }
            return result;
        }

        public IRepository getRepository()
        {   
            return getRepository(Key);
        }

        public static DataStoreFactory Instance { get; private set; }
    }
}