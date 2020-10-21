using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarcinKrupnikLab2
{
    public partial class Form1 : Form
    {
        
        private List<Vehicle> vehiclesList = new List<Vehicle>();
        private int listIndex = 0;
        Vehicle vehicle;

        public Form1()
        {
            InitializeComponent();
            

          }

    
        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeComponent();
            
        }

        private void buttonAddVehicle_Click(object sender, EventArgs e)
        {
            if(radioButtonTram.Checked == true)
            {
                vehicle = new Tram(Int32.Parse(textBoxVehicleNumber.Text),
                    Int32.Parse(textBoxYearOfProduction.Text),
                    textBoxName.Text);
            }
            else 
            {
                vehicle = new Bus(Int32.Parse(textBoxVehicleNumber.Text),
                    Int32.Parse(textBoxYearOfProduction.Text),
                    textBoxName.Text);
            }
            vehiclesList.Add(vehicle);
            // Czyszczenie pól tekstowych.
            textBoxName.Text = "";
            textBoxVehicleNumber.Text = "";
            textBoxYearOfProduction.Text = "";


        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            // Pobieranie danych z listy.
            vehicle = vehiclesList[Math.Abs(listIndex-- % vehiclesList.Count)];
            // pobieranie parametru
            labelActualNumberDesc.Text = vehicle.GetVehicleNumber().ToString();
            labelActualYearDesc.Text = vehicle.GetYearOfProduction().ToString();
            labelActualModelDesc.Text = vehicle.GetName();

            // Jeśli vehicle "wskazuje" na Tramwaj
            if(vehicle is Tram)
            {
                labelActualVehicleDesc.Text = "Tramwaj";     
            }
            else
            {
                labelActualVehicleDesc.Text = "Autobus";
            }

        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            // Pobieranie danych z listy.
            vehicle = vehiclesList[Math.Abs(listIndex++ % vehiclesList.Count)];
            // pobieranie parametru
            labelActualNumberDesc.Text = vehicle.GetVehicleNumber().ToString();
            labelActualYearDesc.Text = vehicle.GetYearOfProduction().ToString();
            labelActualModelDesc.Text = vehicle.GetName();

            // Jeśli vehicle "wskazuje" na Tramwaj
            if (vehicle is Tram)
            {
                labelActualVehicleDesc.Text = "Tramwaj";
            }
            else
            {
                labelActualVehicleDesc.Text = "Autobus";
            }
        }

        private void buttonStartVehicle_Click(object sender, EventArgs e)
        {
            MessageBox.Show(vehicle.StartVehicle());
        }

        private void buttonStopVehicle_Click(object sender, EventArgs e)
        {
            MessageBox.Show(vehicle.StopVehicle());
            List<Tram> tramList = new List<Tram>();
        }

        private void buttonBell_Click(object sender, EventArgs e)
        {
            if (vehicle is Tram)
            {
                Tram tram = (Tram)vehicle;
                MessageBox.Show(tram.Bell());
            }
            else
                MessageBox.Show("Obiekt nie jest tramwajem!");
        }

        private void buttonRefuel_Click(object sender, EventArgs e)
        {
            if(vehicle is Bus)
            {
                Bus bus = (Bus)vehicle;
                MessageBox.Show(bus.Refuel());
            }
            else
            {
                MessageBox.Show("Wybrany obiekt nie jest autobusem");
            }
        }

        private void buttonPantographDown_Click(object sender, EventArgs e)
        {
            if (vehicle is Tram)
            {
                Tram tram = (Tram)vehicle;
                MessageBox.Show(tram.PantographDown());
            }
            else
                MessageBox.Show("Wybrany obiekt nie jest tramwajem");
        }

        private void buttonPantographUp_Click(object sender, EventArgs e)
        {
            if (vehicle is Tram)
            {
                Tram tram = (Tram)vehicle;
                MessageBox.Show(tram.PantographUp());
            }
            else
                MessageBox.Show("Wybrany obiekt nie jest tramwajem");
        }
    }
}
