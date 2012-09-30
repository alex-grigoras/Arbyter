using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arbyter
{
    public class ArbyterCoreFactory
    {
        //singleton pattern
        private static ArbyterCoreFactory _instance = new ArbyterCoreFactory();
        public static ArbyterCoreFactory Instance { get { return _instance; } }
        private ArbyterCoreFactory() { }

        public ArbyterCoreClean GetArbyterClean()
        {
            return new ArbyterCoreClean();
        }

        public ArbyterCoreCopy GetArbyterCopy()
        {
            return new ArbyterCoreCopy();
        }
    }
}
