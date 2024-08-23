using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersistenceStore
{
    internal class TextFileStore : IStore
    {
        TextWriter _writer;
        TextReader _reader;
        public TextFileStore(string filepath)
        {
            Stream stream = File.Create(filepath);
            _writer = new StreamWriter(stream);
            _reader = new StreamReader(stream);
        }

        public void Store(string key, int value)
        {

            _writer.WriteLine(key + " " + value.ToString());
        }

        public int Retrieve(string key)
        {

            return 0;
        }
    }
}
