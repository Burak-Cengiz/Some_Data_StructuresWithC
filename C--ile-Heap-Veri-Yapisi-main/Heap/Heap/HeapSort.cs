using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap
{
    public class HeapSort
    {
        public int[] dizi;
        public HeapSort(int[] dizi)
        {
            this.dizi = dizi;
        }
        public int[] Sort()
        {
            Heap h = new Heap(dizi.Length);
            int[] sorted = new int[dizi.Length];
            //Heap Ağacı Oluştur (nlog(n))
            foreach (var item in dizi)
                h.Insert(item);
            int i = 0;
            //Ağaçtaki maksimum elemanı al ve
            //yeni diziye ekle (nlog(n))
            while (!h.IsEmpty())
                sorted[i++] = h.RemoveMax().Deger;
            return sorted;
        }
        
    }
}
