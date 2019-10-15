using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VechicleAppPractice2
{
    public partial class VehicleUi : Form
    {
        Vehicle vehicle;
        public VehicleUi()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            //string name = vehicleNameTextBox.Text;
            //string regNo = regNoTextBox.Text;
            //string speed = speedTextBox.Text;

            vehicle = new Vehicle(vehicleNameTextBox.Text, regNoTextBox.Text);
            vehicleNameTextBox.Clear();
            regNoTextBox.Clear();



        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            vehicle.SetSpeed(Convert.ToDouble(speedTextBox.Text));
            speedTextBox.Clear();


        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            minSpeedTextBox.Text = vehicle.MinSpeed().ToString();
            maxSpeedTextBox.Text = vehicle.MaxSpeed().ToString();
            averageSpeedTextBox.Text = vehicle.AvgSpeed().ToString();




        }
    }
}
