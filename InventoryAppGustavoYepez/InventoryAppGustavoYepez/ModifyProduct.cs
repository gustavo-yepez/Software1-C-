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
    public partial class ModifyProduct : Form
    {
        BindingList<Part> addedParts = new BindingList<Part>();
        MainForm MainWindow = (MainForm)Application.OpenForms["MainForm"];
        public ModifyProduct(Product selectedProd)
        {
            InitializeComponent();

            modProductIDTextBox.Text = selectedProd.ProductID.ToString();
            modProductNameTextBox.Text = selectedProd.Name;
            modProductInventoryTextBox.Text = selectedProd.Inventory.ToString();
            modProductPriceTextBox.Text = selectedProd.Price.Substring(1).ToString();
            modProductMaxTextBox.Text = selectedProd.Max.ToString();
            modProductMinTextBox.Text = selectedProd.Min.ToString();

            var topTable = new BindingSource();
            topTable.DataSource = Inventory.Parts;
            modCandidatePartsGrid.DataSource = topTable;

            foreach (Part part in selectedProd.AssociatedParts)
            {
                addedParts.Add(part);
            }
            var botTable = new BindingSource();
            botTable.DataSource = addedParts;
            modAssociatedPartsGrid.DataSource = botTable;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ModifyProduct_Load(object sender, EventArgs e)
        {

        }

        private void cancelAddProductbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveNewProductButton_Click(object sender, EventArgs e)
        {
            if (addedParts.Count == 0)
            {
                MessageBox.Show("At least one part must be associated with the product.");
                return;
            }

            int min;
            int max;
            int inventory;
            decimal price;

            try
            {
                min = int.Parse(modProductMinTextBox.Text);
                max = int.Parse(modProductMaxTextBox.Text);
                inventory = int.Parse(modProductInventoryTextBox.Text);
                price = decimal.Parse(modProductPriceTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Error: Inventory, Price, Max and Min must be numeric values.");
                return;
            }

            int id = int.Parse(modProductIDTextBox.Text);
            string name = modProductNameTextBox.Text;
            inventory = int.Parse(modProductInventoryTextBox.Text);
            price = decimal.Parse(modProductPriceTextBox.Text);
            min = int.Parse(modProductMinTextBox.Text);
            max = int.Parse(modProductMaxTextBox.Text);

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

            Product product = new Product(id, name, inventory, price, max, min);
            foreach (Part part in addedParts)
            {
                product.AddAssociatedPart(part);
            }
            Inventory.UpdateProduct(id, product);
            Close();

            MainWindow.productGridView.Update();
            MainWindow.productGridView.Refresh();
        }

        private void addPartToItemButton_Click(object sender, EventArgs e)
        {
            Part part = (Part)modCandidatePartsGrid.CurrentRow.DataBoundItem;
            addedParts.Add(part);
        }

        private void modPartSearchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchPartListButton_Click(object sender, EventArgs e)
        {
            int partID = int.Parse(modPartSearchTextBox.Text);
            Part match = Inventory.LookupPart(partID);
            foreach (DataGridViewRow row in modCandidatePartsGrid.Rows)
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

        private void deleteAssociatedPartButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete? This cannot be undone.", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {

                Part part = (Part)modAssociatedPartsGrid.CurrentRow.DataBoundItem;
                int id = int.Parse(modProductIDTextBox.Text);

                Product product = Inventory.LookupProduct(id);
                product.RemoveAssociatedPart(part.PartID);

                foreach (DataGridViewRow row in modAssociatedPartsGrid.SelectedRows)
                {
                    modAssociatedPartsGrid.Rows.RemoveAt(row.Index);
                }
            }
            else return;
        }
    }
}
