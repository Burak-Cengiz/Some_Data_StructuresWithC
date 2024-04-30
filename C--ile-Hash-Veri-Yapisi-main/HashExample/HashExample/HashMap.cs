using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashExample
{
    public class HashMap
    {
        const int maxSize = 10; 
        HashEntry[] table;
        public HashMap()
        {
            table = new HashEntry[maxSize];
            for (int i = 0; i < maxSize; i++)
            {
                table[i] = null;
            }
        }
        public string retrieve(int key)
        {
            int hash = key % maxSize;
            while (table[hash] != null && table[hash].getkey() != key)
            {
                hash = (hash + 1) % maxSize;
            }
            if (table[hash] == null)
            {
                return "nothing found!";
            }
            else
            {
                return table[hash].getdata();
            }
        }
        public void insert(int key, string data)
        {
            if (!checkOpenSpace())
            {
                throw new Exception("Kapasite full!");               
            }
            int hash = (key % maxSize);
            while (table[hash] != null && table[hash].getkey() != key)
            {
                hash = (hash + 1) % maxSize;
            }
            table[hash] = new HashEntry(key, data);
        }
        private bool checkOpenSpace()
        {
            bool isOpen = false;
            for (int i = 0; i < maxSize; i++)
            {
                if (table[i] == null)
                {
                    isOpen = true;
                }
            }
            return isOpen;
        }
        public bool remove(int key)
        {
            int hash = key % maxSize;
            while (table[hash] != null && table[hash].getkey() != key)
            {
                hash = (hash + 1) % maxSize;
            }
            if (table[hash] == null)
            {
                return false;
            }
            else
            {
                table[hash] = null;
                return true;
            }
        }
        public string print()
        {
            string tmp = "";
            for (int i = 0; i < table.Length; i++)
            {
                if (table[i] == null && i <= maxSize)
                {
                    continue;
                }
                else
                {

                    tmp += table[i].getdata();
                }
            }
            return tmp;
        }
        public void quadraticHashInsert(int key, string data)
        {
           
            if (!checkOpenSpace())
            {
                throw new Exception("Kapasite full!");
              
            }

            int j = 0;
            int hash = key % maxSize;
            while (table[hash] != null && table[hash].getkey() != key)
            {
                j++;
                hash = (hash + j * j) % maxSize;
            }
            if (table[hash] == null)
            {
                table[hash] = new HashEntry(key, data);
                return;
            }
        }
        public void doubleHashInsert(int key, string data)
        {
            if (!checkOpenSpace())
            {
                throw new Exception("Kapasite full!");
                return;
            }

            
            int hashVal = hash1(key);
            int stepSize = hash2(key);

            while (table[hashVal] != null && table[hashVal].getkey() != key)
            {
                hashVal = (hashVal + stepSize * hash2(key)) % maxSize;
            }
            table[hashVal] = new HashEntry(key, data);
            return;
        }
        private int hash1(int key)
        {
            return key % maxSize;
        }
        private int hash2(int key)
        {
            
            return 5 - key % 5;
        }
    }
}
