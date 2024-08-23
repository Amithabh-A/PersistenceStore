using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersistenceStore
{
    internal abstract class StoreBase : IStore
    {
        public StoreBase()
        {

        }

        public void Store(string key, int value)
        {

        }

        public int Retrieve(string key)
        {

            return 0; 
        }
    }
}
