using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stack_LinkedList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Test_Click(object sender, EventArgs e)
        {
            IStack stack = new IStack(5);

            string temp = "";
            stack.Push(4);
            stack.Push(5);
            temp = stack.Peek().ToString();
            MessageBox.Show(temp);
            stack.Pop();
            temp = stack.Peek().ToString();
            MessageBox.Show(temp);
            stack.Push(1);
            temp = stack.Peek().ToString();
            MessageBox.Show(temp);

        }
    }
}
