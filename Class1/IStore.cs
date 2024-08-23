using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersistenceStore
{
    public interface IStore
    {
        public void Store(String key, int value);
        int Retrieve(String key);
    }
}
