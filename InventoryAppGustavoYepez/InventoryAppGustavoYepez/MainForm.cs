using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InventoryAppGustavoYepez
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            Inventory.ExampleItems();

            var partTable = new BindingSource();
            partTable.DataSource = Inventory.Parts;
            partGridView.DataSource = partTable;
            partGridView.ClearSelection();

            var prodTable = new BindingSource();
            prodTable.DataSource = Inventory.Products;
            productGridView.DataSource = prodTable;
            productGridView.ClearSelection();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void addPartButton_Click(object sender, EventArgs e)
        {
            new Add_Part().ShowDialog();
        }

        private void modifyPartButton_Click(object sender, EventArgs e)
        {
            if (partGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to modify.");
                return;
            }
            if (partGridView.CurrentRow.DataBoundItem.GetType() == typeof(InventoryAppGustavoYepez.Inhouse))
            {
                Inhouse inhouse = (Inhouse)partGridView.CurrentRow.DataBoundItem;
                new ModifyPart(inhouse).ShowDialog();
            }
            else
            {
                OutSourced outSourced = (OutSourced)partGridView.CurrentRow.DataBoundItem;
                new ModifyPart(outSourced).ShowDialog();
            }
        }

        private void deletePartButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete? This cannot be undone.", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in partGridView.SelectedRows)
                {
                    partGridView.Rows.RemoveAt(row.Index);
                }
            }
            else return;
        }

        private void searchPartButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(partSearchTextBox.Text, out int searchValue))
            {
                Part match = Inventory.LookupPart(searchValue);
                if (match != null)
                {
                    foreach (DataGridViewRow row in partGridView.Rows)
                    {
                        Part part = (Part)row.DataBoundItem;
                        row.Selected = part.PartID == match.PartID;
                        if (row.Selected)
                        {
                            partGridView.FirstDisplayedScrollingRowIndex = row.Index;
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No part found with the given ID.");
                }
            }
            else
            {
                string searchString = partSearchTextBox.Text.ToLower();
                bool found = false;

                foreach (DataGridViewRow row in partGridView.Rows)
                {
                    Part part = (Part)row.DataBoundItem;
                    if (part.Name.ToLower().Contains(searchString))
                    {
                        row.Selected = true;
                        found = true;
                        partGridView.FirstDisplayedScrollingRowIndex = row.Index;
                        break; 
                    }
                }

                if (!found)
                {
                    MessageBox.Show("No part found with the given name.");
                }
            }
        }

        private void modifyProductButton_Click(object sender, EventArgs e)
        {
            if (productGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to modify.");
                return;
            }

            Product selectedProd = (Product)productGridView.CurrentRow.DataBoundItem;
            new ModifyProduct(selectedProd).ShowDialog();
        }

        private void deleteProductButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete? This cannot be undone.", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Product product = (Product)productGridView.CurrentRow.DataBoundItem;
                if (product.AssociatedParts.Count > 0)
                {
                    MessageBox.Show("Cannot delete product with associated parts. Please remove parts attached to this product.");
                    return;
                }
                foreach (DataGridViewRow row in productGridView.SelectedRows)
                {
                    productGridView.Rows.RemoveAt(row.Index);
                }
            }
            else return;
        }

        private void searchProductButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(productSearchTextBox.Text, out int searchValue))
            {
                Product match = Inventory.LookupProduct(searchValue);
                if (match != null)
                {
                    foreach (DataGridViewRow row in productGridView.Rows)
                    {
                        Product product = (Product)row.DataBoundItem; 
                        if (product.ProductID == match.ProductID)
                        {
                            row.Selected = true;
                            productGridView.FirstDisplayedScrollingRowIndex = row.Index;
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No Product found with the given ID.");
                }
            }
            else
            {
                string searchString = productSearchTextBox.Text.ToLower();
                bool found = false;

                foreach (DataGridViewRow row in productGridView.Rows)
                {
                    Product prod = (Product)row.DataBoundItem;
                    if (prod.Name.ToLower().Contains(searchString))
                    {
                        row.Selected = true;
                        found = true;
                        productGridView.FirstDisplayedScrollingRowIndex = row.Index;
                        break;
                    }
                }

                if (!found)
                {
                    MessageBox.Show("No Product found with the given name.");
                }
            }
        }

        private void exitAppButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            new AddProducts().ShowDialog();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            partGridView.ClearSelection();
            productGridView.ClearSelection();
        }
    }
}
