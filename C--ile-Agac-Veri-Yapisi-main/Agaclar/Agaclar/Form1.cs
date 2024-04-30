using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agaclar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ikili_agac Ikili_Agac = new Ikili_agac(15);                      
            AgacIslemler agac2 = new AgacIslemler(Ikili_Agac);

            agac2.Ekle(2);
            agac2.Ekle(6);
            agac2.Ekle(74);
            agac2.Ekle(17);
            agac2.Ekle(5);
            agac2.Ekle(26);
            agac2.Ekle(13);
            agac2.Ekle(14);
            agac2.Ekle(16);
            agac2.Ekle(18);

            agac2.Preorder(Ikili_Agac);
            MessageBox.Show(agac2.dugumler);
            agac2.Sil(18);
            agac2.Preorder(Ikili_Agac);
            MessageBox.Show(agac2.dugumler);


        }
    }
}
