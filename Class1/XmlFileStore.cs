using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersistenceStore
{
    internal class XmlFileStore
    {
        TextWriter _writer;
        TextReader _reader;
        public XmlFileStore()
        {
            Stream stream = File.Create("XmlFileStore.txt"); 

        }
    }
}
