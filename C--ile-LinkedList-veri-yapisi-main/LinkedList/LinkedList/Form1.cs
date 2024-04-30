using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkedList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        ILinkedList List = new ILinkedList();
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                List.InsertFirst(Convert.ToInt32(Sayitxtbx1.Text));
                MessageBox.Show("Sayı başarıyla listenin başına eklendi! Sayı:" + Sayitxtbx1.Text);
            }
            catch (Exception)
            {

                throw;
            }
            
                       
        }

        private void SonaEkleBtn2_Click(object sender, EventArgs e)
        {
            try
            {

                List.InsertLast(Convert.ToInt32(Sayitxtbx1.Text));
                MessageBox.Show("Sayı başarıyla listenin sonuna eklendi! Sayı:" + Sayitxtbx1.Text);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void ListeGösterbtn_Click(object sender, EventArgs e)
        {


            try
            {
                MessageBox.Show(List.DisplayElements() + "  Listenin Boyutu :" + List.Count);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.ToString());
            }
                
                
            
        }

        private void TrsCvrBrn_Click(object sender, EventArgs e)
        {
            List.Reverse(ref List.Head);
            MessageBox.Show(List.DisplayElements());
            
        }

        private void btnAraya_Click(object sender, EventArgs e)
        {
            List.InsertBetwen(Convert.ToInt32(Sayitxtbx1.Text), Convert.ToInt32(Arayatxtbx.Text));
            MessageBox.Show(List.DisplayElements());
        }

        private void btnYnlenenCikar_Click(object sender, EventArgs e)
        {
            List.YinelenenCıkar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }
    }
}
