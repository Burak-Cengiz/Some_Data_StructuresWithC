using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Heap heap = new Heap(100);
            heap.Insert(35);
            heap.Insert(10);
            heap.Insert(57);
            heap.Insert(1);
            heap.Insert(74);
            heap.Insert(3);
            int[] dizi = { 5, 1, 7, 3, 9, 14, 3, 6 };
            HeapSort heapSort = new HeapSort(dizi);
            dizi = heapSort.Sort();

            string tmp = "";
            for (int i = 0; i < dizi.Length; i++)
            {
                
                tmp += dizi[i].ToString() + " ";

            }

            MessageBox.Show(tmp);
        }
    }
}
