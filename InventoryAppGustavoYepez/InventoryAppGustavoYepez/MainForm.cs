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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            Inventory.ExampleItems();

            var partTable = new BindingSource();
            partTable.DataSource = Inventory.Parts;
            partGridView.DataSource = partTable;

            var prodTable = new BindingSource();
            prodTable.DataSource = Inventory.Products;
            productGridView.DataSource = prodTable;
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
            int searchValue = int.Parse(partSearchTextBox.Text);

            if (searchValue < 1) return;

            Part match = Inventory.LookupPart(int.Parse(partSearchTextBox.Text));


            foreach (DataGridViewRow row in partGridView.Rows)
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

        private void modifyProductButton_Click(object sender, EventArgs e)
        {
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
            int searchValue = int.Parse(productSearchTextBox.Text);

            if (searchValue < 1) return;

            Product match = Inventory.LookupProduct(int.Parse(productSearchTextBox.Text));


            foreach (DataGridViewRow row in productGridView.Rows)
            {
                Product product = (Product)row.DataBoundItem;
                if (product.ProductID == match.ProductID)
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

        private void exitAppButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            new AddProducts().ShowDialog();
        }
    }
}
