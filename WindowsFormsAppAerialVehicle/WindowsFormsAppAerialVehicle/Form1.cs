using OOPFlyingVehicle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppAerialVehicle
{
    public partial class Form1 : Form
    {

        AerialVehicle vehicle;

        public List<AerialVehicle> Vehicles;

        public Form1()
        {
            InitializeComponent();

            Vehicles = new List<AerialVehicle>()
            {
                new Airplane() { picture="Airplane1.bmp" },
                new Helicopter() {picture="Helicopter1.bmp"}
            };

            //Load all pictures
            foreach (var v in Vehicles)
            {
                v.LoadPicture();
            }

            vehicle = Vehicles[0];
            
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void UpdateUI()
        {
            UpdateAboutTextBox();
            UpdateVehicleHeight();
        }

        private void UpdateVehicleHeight()
        {
            int panelBottom = panel1.Height - vehicle.Pb.Height;
            float panelRealtiveHeight = ((float)vehicle.CurrentAltitude / (float)vehicle.MaxAltitude);

            vehicle.Pb.Location = new Point(0, (int)(panelBottom - panelRealtiveHeight * (panel1.Height - vehicle.Pb.Height))); 
        }

        private void UpdateAboutTextBox()
        {
            textBoxAbout.Text = vehicle.About();
        }

        private void comboBoxAerialVehicle_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBoxAerialVehicle.SelectedItem)
            {
                case "Airplane":
                    vehicle = Vehicles[0];
                    
                    
                    break;
                case "Helicopter":
                    vehicle = Vehicles[1];
                    break;
            }
            panel1.Controls.Clear();
            panel1.Controls.Add(vehicle.Pb);
            UpdateVehicleHeight();
        }

        private void ButtonUp_Click(object sender, EventArgs e)
        {
            this.vehicle.FlyUp();
            UpdateUI();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.vehicle.FlyDown();
            UpdateUI();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            this.vehicle.StartEngine();
            UpdateUI();
        }

        private void buttonTakeOff_Click(object sender, EventArgs e)
        {
            this.vehicle.TakeOff();
            UpdateUI();
        }
    }
}
