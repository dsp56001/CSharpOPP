using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplicationHello2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Button btnGoodbye = new Button();
            btnGoodbye.Text = "Press Me";
            btnGoodbye.Click += btnGoodbye_Click;
            panel1.Controls.Add(btnGoodbye);
        }

        void btnGoodbye_Click(object sender, EventArgs e)
        {
            label1.Text = "Goodbye World";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Hello World";
        }
    }
}
