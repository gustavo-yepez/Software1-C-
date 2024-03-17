using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryAppGustavoYepez
{
    public partial class ModifyPart : Form
    {
        MainForm MainWindow = (MainForm)Application.OpenForms["MainForm"];
        public ModifyPart(Inhouse inPart)
        {
            InitializeComponent();
            modPartIDTextBox.Text = inPart.PartID.ToString();
            modPartNameTextBox.Text = inPart.Name;
            modPartInventoryTextBox.Text = inPart.Inventory.ToString();
            modPartCostTextBox.Text = inPart.Price.Substring(1).ToString();
            modPartMaxTextBox.Text = inPart.Max.ToString();
            modPartMinTextBox.Text = inPart.Min.ToString();
            modPartMacComTextBox.Text = inPart.MachineID.ToString();
        } 
        
        public ModifyPart(OutSourced outPart)
        {
            InitializeComponent();
            modPartIDTextBox.Text = outPart.PartID.ToString();
            modPartNameTextBox.Text = outPart.Name;
            modPartInventoryTextBox.Text = outPart.Inventory.ToString();
            modPartCostTextBox.Text = outPart.Price.Substring(1).ToString();
            modPartMaxTextBox.Text = outPart.Max.ToString();
            modPartMinTextBox.Text = outPart.Min.ToString();
            modPartMacComTextBox.Text = outPart.CompName;
            outsourcedRadioButton.Checked = true;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void partMinTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void partMaxTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void partCostTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void partInventoryTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void partNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void partIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cancelPartCreationButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void savePartButton_Click(object sender, EventArgs e)
        {
            int minStock;
            int maxStock;
            int invInStock;
            decimal price;

            try
            {
                minStock = int.Parse(modPartMinTextBox.Text);
                maxStock = int.Parse(modPartMaxTextBox.Text);
                invInStock = int.Parse(modPartInventoryTextBox.Text);
                price = decimal.Parse(modPartCostTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Error: Inventory, Price, Max and Min must be numeric values.");
                return;
            }

            int id = int.Parse(modPartIDTextBox.Text);
            string name = modPartNameTextBox.Text;
            price = decimal.Parse(modPartCostTextBox.Text);
            minStock = int.Parse(modPartMinTextBox.Text);
            maxStock = int.Parse(modPartMaxTextBox.Text);
            invInStock = int.Parse(modPartInventoryTextBox.Text);

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

            if (inhouseRadioButton.Checked)
            {
                if (!int.TryParse(modPartMacComTextBox.Text, out int machineId))
                {
                    MessageBox.Show("Please enter a valid numeric Machine ID.");
                    return;
                }

                Inhouse inPart = new Inhouse(id, name, invInStock, price, maxStock, minStock, int.Parse(modPartMacComTextBox.Text));
                Inventory.UpdatePart(id, inPart);
                
            }
            else if (outsourcedRadioButton.Checked)
            {
                string companyName = modPartMacComTextBox.Text;

                if (string.IsNullOrWhiteSpace(companyName) || !companyName.All(c => char.IsLetter(c) || c == ' '))
                {
                    MessageBox.Show("Please enter a company a valid name.");
                    return;
                }

                OutSourced outPart = new OutSourced(id, name, invInStock, price, maxStock, minStock, companyName);
                Inventory.UpdatePart(id, outPart);
            }
            else
            {
                MessageBox.Show("Please select a part type.");
                return;
            }
            Close();
            MainWindow.partGridView.Update();
            MainWindow.partGridView.Refresh();

        }

        private void PartMacComTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void OutsourcedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void InhouseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void ModifyPart_Load(object sender, EventArgs e)
        {

        }

        private void outsourcedRadioButton_CheckedChanged_1(object sender, EventArgs e)
        {
                    }

        private void inhouseRadioButton_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void inhouseRadioButton_CheckedChanged_2(object sender, EventArgs e)
        {
            {
                partMacComID.Text = "Machine ID";
            }

        }

        private void outsourcedRadioButton_CheckedChanged_2(object sender, EventArgs e)
        {
            partMacComID.Text = "Company Name ";
        }
    }
}
