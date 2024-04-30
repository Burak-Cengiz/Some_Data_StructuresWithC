using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashExample
{
    public class HashEntry
    {
        private int key;
        private string data;
        public HashEntry(int key, string data)
        {
            this.key = key;
            this.data = data;
        }
        public int getkey()
        {
            return key;
        }
        public string getdata()
        {
            return data;
        }
    }
}
