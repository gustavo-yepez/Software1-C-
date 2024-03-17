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
    public partial class AddProducts : Form
    {
        BindingList<Part> addedParts = new BindingList<Part>();
        public AddProducts()
        {
            InitializeComponent();
            var topTable = new BindingSource();
            topTable.DataSource = Inventory.Parts;
            candidatePartsGrid.DataSource = topTable;

            var botTable = new BindingSource();
            botTable.DataSource = addedParts;
            associatedPartsGrid.DataSource = botTable;
        }

        private void AddProducts_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Part partToAdd = (Part)candidatePartsGrid.CurrentRow.DataBoundItem;
            addedParts.Add(partToAdd);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete? This cannot be undone.", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {

                foreach (DataGridViewRow row in associatedPartsGrid.SelectedRows)
                {
                    associatedPartsGrid.Rows.RemoveAt(row.Index);
                }
            }
            else return;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int partID = int.Parse(searchPartTextBox.Text);
            Part match = Inventory.LookupPart(partID);
            foreach (DataGridViewRow row in candidatePartsGrid.Rows)
            {
                Part part = (Part)row.DataBoundItem;
                if (part.PartID == match.PartID)
                {
                    row.Selected = true;
                    break;
                }
                else
                {
                    row.Selected = false;
                }
            }
        }

        private void cancelAddProductbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveNewProductButton_Click(object sender, EventArgs e)
        {
            int inventory;
            int min;
            int max;
            decimal price;

            try
            {
                min = int.Parse(addProductMinTextBox.Text);
                max = int.Parse(addProductMaxTextBox.Text);
                inventory = int.Parse(addProductInventoryTextBox.Text);
                price = decimal.Parse(addProductPriceTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Error: Inventory, Price, Max and Min text fields must be numeric values.");
                return;
            }

            string name = addProductNameTextBox.Text;
            inventory = int.Parse(addProductInventoryTextBox.Text);
            price = decimal.Parse(addProductPriceTextBox.Text);
            min = int.Parse(addProductMinTextBox.Text);
            max = int.Parse(addProductMaxTextBox.Text);

            if (min > max)
            {
                MessageBox.Show("Error: min cannot be greater than max");
                return;
            }

            if (inventory > max || inventory < min)
            {
                MessageBox.Show("Error: Inventory must be between max and min inventory");
                return;
            }

            Product product = new Product((Inventory.Products.Count + 1), name, inventory, price, max, min);
            Inventory.AddProduct(product);

            foreach (Part part in addedParts)
            {
                product.AddAssociatedPart(part);
            }
            Close();
        }

        private void searchPartListButton_Click(object sender, EventArgs e)
        {
            int partID = int.Parse(searchPartTextBox.Text);
            Part match = Inventory.LookupPart(partID);
            foreach (DataGridViewRow row in candidatePartsGrid.Rows)
            {
                Part part = (Part)row.DataBoundItem;
                if (part.PartID == match.PartID)
                {
                    row.Selected = true;
                    break;
                }
                else
                {
                    row.Selected = false;
                }
            }
        }
    }
}
