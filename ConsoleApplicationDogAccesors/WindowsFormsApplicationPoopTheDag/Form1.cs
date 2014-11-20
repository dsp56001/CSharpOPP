using Animals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplicationPoopTheDag
{
    public partial class Form1 : Form
    {
        Dog d;
        Button b = new Button();
        
        public Form1()
        {
            b.Location = new System.Drawing.Point(120, 58);
            b.Name = "button1";
            b.Size = new System.Drawing.Size(90, 25);
            b.TabIndex = 2;
            b.Text = "Poop";
            b.Click += b_Click;
            this.Controls.Add(b);
            InitializeComponent();
            d = new Dog();
            UpdateTextBox();
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            
            
        }

        void timer1_Tick(object sender, EventArgs e)
        {
            if (d.Weight > 0)
            {
                d.Poop();
                this.UpdateTextBox();
            }
        }

        void b_Click(object sender, EventArgs e)
        {
            d.Poop();
            timer1.Stop();
            this.UpdateTextBox();
        }

        private void UpdateTextBox()
        {
            textBoxDog.Text = d.About();
        }

        private void labelDog_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            d.Eat();
            timer1.Start();
            this.UpdateTextBox();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
