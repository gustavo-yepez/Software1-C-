using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryAppGustavoYepez
{
    public partial class Add_Part : Form
    {
        public Add_Part()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "Machine ID";
        }

        private void Add_Part_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void outsourcedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "Company Name";
        }

        private void partIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void partNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void partInventoryTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void partCostTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void partMaxTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void partMacComTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void partMinTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void savePartButton_Click(object sender, EventArgs e)
        {
            int minStock;
            int maxStock;
            int invInStock;
            decimal price;

            try
            {
                minStock = int.Parse(partMinTextBox.Text);
                maxStock = int.Parse(partMaxTextBox.Text);
                invInStock = int.Parse(partInventoryTextBox.Text);
                price = decimal.Parse(partCostTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Error: Inventory, Price, Max and Min text fields must be numeric values.");
                return;
            }



            string name = partNameTextBox.Text;
            price = decimal.Parse(partCostTextBox.Text);
            minStock = int.Parse(partMinTextBox.Text);
            maxStock = int.Parse(partMaxTextBox.Text);
            invInStock = int.Parse(partInventoryTextBox.Text);


            if (minStock > maxStock)
            {
                MessageBox.Show("Error: Max must be greater than min");
                return;
            }

            if (invInStock > maxStock || invInStock < minStock)
            {
                MessageBox.Show("Error: Inventory must be between max and min inventory");
                return;
            }


            if (int.TryParse(partMacComTextBox.Text, out int machineId))
            {
                Inhouse inPart = new Inhouse(Inventory.Parts.Count + 1, name, invInStock, price, maxStock, minStock, machineId);
                Inventory.AddPart(inPart);
                Close();
            }
            else
            {
                OutSourced outPart = new OutSourced((Inventory.Parts.Count + 1), name, invInStock, price, maxStock, minStock, partMacComTextBox.Text);
                Inventory.AddPart(outPart);

            }
            Close();
        }

        private void cancelPartCreationButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
