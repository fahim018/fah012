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

        private Vehicle Vehicle;
        public VehicleUi()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            Vehicle  = new Vehicle(vehicleNameTextBox.Text,Convert.ToInt32(regNoTextBox.Text));
            vehicleNameTextBox.Clear();
            regNoTextBox.Clear();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            Vehicle.speed.Add(Convert.ToDouble(speedTextBox.Text));
            speedTextBox.Clear();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            maxSpeedTextBox.Text = Vehicle.GetMax().ToString();
            minSpeedTextBox.Text = Vehicle.GetMin().ToString();
            averageSpeedTextBox.Text = Vehicle.GetAvg().ToString();
        }
    }
}
