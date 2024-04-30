using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Queue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            Ikuyruk queue = new Ikuyruk(3);
            queue.push(1);
            queue.push(2);
            queue.push(3);

            MessageBox.Show(queue.peek().ToString());
            MessageBox.Show(queue.displayElements());

            queue.pop();

            MessageBox.Show(queue.peek().ToString());
            MessageBox.Show(queue.displayElements());
        }
    }
}
