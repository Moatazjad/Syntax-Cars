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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Syntax_Cars
{
    public partial class Form3 : Form
    {
        List<CAR> carsToShow = new List<CAR>();
        public Form3()
        {
            InitializeComponent();
            ListCarDatabase();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }


        private void RefreshTags(CAR cars)
        {
            if (cars != null)
            {
                idlbl.Text = cars.ID;
                brandlbl.Text = cars.Brand; 
                modellbl.Text = cars.Model; 
                pricelbl.Text = cars.Price.ToString();
                    
            }
            else
            {
                idlbl.Text = "_";
                brandlbl.Text = "_"; 
                modellbl.Text = "_"; 
                pricelbl.Text = "_";
            }
           Refresh();   
        }

        private void ListCarDatabase()
        {

            listBox1.Items.Clear();

            List<string> result = new List<string>();

            foreach (var type in CarDatabase.allCars.Keys)
            {
                foreach (var cars in CarDatabase.allCars[type])
                {

                    listBox1.Items.Add($"{cars.Type},{cars.ID}, {cars.Model}, {cars.Type}, {cars.Brand}, {cars.Price}");
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCar = listBox1.SelectedItem.ToString();
            string[] splittedCar = selectedCar.Split(',');
            CAR cars = CarDatabase.GetCars<CAR>(splittedCar[0], splittedCar[1]);
            RefreshTags(cars);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            CarDatabase.ReadFromFile();
            comboBox2.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }
    }
}
