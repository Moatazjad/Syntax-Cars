using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Syntax_Cars
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != null)
            {
                string selectedProduct = comboBox1.SelectedItem.ToString();

                groupBoxSedan.Enabled = false;
                groupBoxHybrid.Enabled = false;
                groupBoxSport.Enabled = false;

                if (selectedProduct == "Sedan")
                {
                    groupBoxSedan.Enabled = true;
                }
                else
                {
                    if (selectedProduct == "Hybrid")
                    {
                        groupBoxHybrid.Enabled = true;
                    }
                    else if (selectedProduct == "Sport")
                    {
                        groupBoxSport.Enabled = true;
                    }
                }
            }
        }

        private void Proceed_Click(object sender, EventArgs e)
        {
            string SelectedOption = comboBox1.SelectedItem.ToString()?.Trim();

            groupBoxSedan.Enabled = SelectedOption == "Sedan";
            groupBoxHybrid.Enabled = SelectedOption == "Hybrid";
            groupBoxSport.Enabled = SelectedOption == "Sport";
        }

        private void groupBoxSedan_Enter(object sender, EventArgs e)
        {

        }

        private void sedanbtn_Click(object sender, EventArgs e)
        {
            Sedan sedan = new Sedan
                 (ID: idtxt.Text,
                 Type: comboBox1.Text,
                 Brand: brandtxt.Text,
                 Model: modelttxt.Text,
                 Price: Convert.ToInt32(pricetxt.Text),
                 Fuel: Convert.ToBoolean(Petrolbtn.Checked),
                 Diesel: Convert.ToBoolean(dieselbtn.Checked),
                 TrunkCapacity: Convert.ToInt32(trunktxt.Text));

            CarDatabase.AddCars(comboBox1.SelectedItem.ToString(), sedan);

            MessageBox.Show($"The Car has been added");
        }



        private void sportbtn_Click_1(object sender, EventArgs e)
        {
            Sport sport = new Sport
                (ID: idtxt.Text,
                Type: comboBox1.Text,
                Brand: brandtxt.Text,
                Model: modelttxt.Text,
                EngineSpecs: enginetxt.Text,
                Price: Convert.ToInt32(pricetxt.Text),
                Acceleration: Convert.ToInt32(accelerationtxt.Text),
                TopSpeed: Convert.ToInt32(topspeedtxt.Text));
            CarDatabase.AddCars(comboBox1.SelectedItem.ToString(), sport);

            MessageBox.Show($"The Car has been added");
        }

        private void Menu_Click_1(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void hybridbtn_Click_1(object sender, EventArgs e)
        {
            Hybrid hybrid = new Hybrid
              (ID: idtxt.Text,
              Type: comboBox1.Text,
              Brand: brandtxt.Text,
              Model: modelttxt.Text,
              Price: Convert.ToInt32(pricetxt.Text),
              BatteryRange: Convert.ToInt32(batterytxt.Text),
             ChargingTime: Convert.ToInt32(chargingtxt.Text),
             RoofWindow: Convert.ToBoolean(roofbtn.Checked));

            CarDatabase.AddCars(comboBox1.SelectedItem.ToString(), hybrid);

            MessageBox.Show($"The Car has been added");
        }

        private void Petrolbtn_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
