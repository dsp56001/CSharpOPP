using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsoleApplicationStaticDob;

namespace WindowsFormDog
{
    public partial class Form1 : Form
    {
        Dog d;
        
        public Form1()
        {
            InitializeComponent();
            d = new Dog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateAboutUI();
        }

        private void UpdateAboutUI()
        {
            textBoxAboutDog.Text += d.About();
        }

        private void buttonBark_Click(object sender, EventArgs e)
        {
            textBoxAboutDog.Text += d.Bark();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            d.ChangeOwner(new Person("Jeff"));
            UpdateAboutUI();
        }
    }
}
