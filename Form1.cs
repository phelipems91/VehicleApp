using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleApp
{
    public partial class Form1 : Form
    {
        List<Vehicle> vehicle = new List<Vehicle>();
        Vehicle vehicleFound;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rbtnCar.Checked = true;
        }

        private void rbtnCar_CheckedChanged(object sender, EventArgs e)
        {
            grpForCars.Enabled = rbtnCar.Checked;
            grpForBikes.Enabled = rbtnBicycle.Checked;
        }

        private void btnCreateVehicle_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbtnCar.Checked)
                {
                    Car c = new Car(txtName.Text, txtBrand.Text, double.Parse(txtPrice.Text), int.Parse(txtWarranty.Text), txtStore.Text, (int)nrudPasengers.Value, cboFuel.Text);
                    vehicle.Add(c);
                }
                else
                {
                    Bicycle b = new Bicycle(txtName.Text, txtBrand.Text, double.Parse(txtPrice.Text), int.Parse(txtWarranty.Text), txtStore.Text, (int)nrudTireSize.Value, cboTerrain.Text);
                    vehicle.Add(b);
                }
            }catch(FormatException)
            {
                MessageBox.Show("Invalid Format");
            }

            MessageBox.Show($"Total number of vehicles: {vehicle.Count}");

            clearFields();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            vehicleFound = null;

            foreach (Vehicle v in vehicle)
                if (v.Name == txtNameSearch.Text)
                    vehicleFound = v;


            if (vehicleFound != null)
            {
                txtName.Text = vehicleFound.Name;
                txtBrand.Text = vehicleFound.Brand;
                txtPrice.Text = vehicleFound.Price.ToString();
                txtWarranty.Text = vehicleFound.Warranty.ToString();
                txtStore.Text = vehicleFound.Store;

                if (vehicleFound.GetType() == typeof(Car))
                {
                    nrudPasengers.Value = ((Car)vehicleFound).NumberOfPassengers;
                    cboFuel.Text = ((Car)vehicleFound).Fuel;
                    rbtnCar.Checked = true;
                }
                else
                {
                    nrudTireSize.Value = ((Bicycle)vehicleFound).TireSize;
                    cboTerrain.Text = ((Bicycle)vehicleFound).Terrain;
                    rbtnBicycle.Checked = true;
                }
            }
            else 
            {
                MessageBox.Show("Vehicle not found!");
                clearFields();
            }  
        }

        private void btnMakeSale_Click(object sender, EventArgs e)
        {
            MessageBox.Show(vehicleFound.MakeSale());
        }

        private void btnCalcInterest_Click(object sender, EventArgs e)
        {
            MessageBox.Show(vehicleFound.CalculateInterest().ToString());
        }

        private void clearFields()
        {
            txtName.Text = "";
            txtBrand.Text = "";
            txtPrice.Text = "";
            txtWarranty.Text = "";
            txtStore.Text = "";
            nrudPasengers.Value = 0;
            cboFuel.Text = "";
            nrudTireSize.Value = 0;
            cboTerrain.Text = "";
            rbtnCar.Checked = true;
            txtNameSearch.Text = "";
        }
    }
}
