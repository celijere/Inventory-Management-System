using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IMS.Extensions;
using IMS.Models;

namespace IMS
{
    public partial class AddProduct : Form
    {
        private Inventory inventory;
        private Product product;
        public AddProduct(Inventory inventory)
        {
            InitializeComponent();
            this.inventory = inventory;
            this.product = new Product();

            allCandidateParts.DataSource = inventory.AllParts;
            allAssociatedParts.DataSource = product.AssociatedParts;

            allCandidateParts.CellClick += candidateParts_CellClick;
            allAssociatedParts.CellClick += associatedParts_CellClick;
        }

        private void addProductIDIncrement(object sender, EventArgs e)
        {
            int productID = 1;

            if (inventory.Products.Count != 0)
            {
                productID = inventory.Products.Max(product => product.ProductID) + 1;
            }

            addProductIDTextBox.Text = productID.ToString();
        }

        private void saveAddProduct_Click(object sender, EventArgs e)
        {
            if (int.TryParse(addProductIDTextBox.Text, out int productID) == false)
            {
                MessageBox.Show("Product ID is not a valid integer");
                return;
            }
            product.ProductID = productID;
            product.Name = addProductNameTextBox.Text;
            if (string.IsNullOrWhiteSpace(product.Name))
            {
                MessageBox.Show("Product name cannot be empty");
                return;
            }
            if (int.TryParse(addProductInventoryTextBox.Text, out int InStock) == false)
            {
                MessageBox.Show("Inventory is not a valid integer");
                return;
            }
            product.InStock = InStock;
            if (decimal.TryParse(addProductPTextBox.Text, out decimal Price) == false)
            {
                MessageBox.Show("Price is not a valid decimal");
                return;
            }
            product.Price = Price;
            if (int.TryParse(addProductMinTextBox.Text, out int Min) == false)
            {
                MessageBox.Show("Min is not a valid integer");
                return;
            }
            product.Min = Min;
            if (int.TryParse(addProductMaxTextBox.Text, out int Max) == false)
            {
                MessageBox.Show("Max is not a valid integer");
                return;
            }
            product.Max = Max;
            if (Min > Max)
            {
                MessageBox.Show("Min is higher than Max");
                return;
            }
            if (InStock < Min || InStock > Max)
            {
                MessageBox.Show("Inventory is outside of Min/Max range");
                return;
            }
            inventory.addProduct(this.product);

            Close();
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            if (allCandidateParts.SelectedRows.Count > 0)
            {
                var selectedRow = allCandidateParts.SelectedRows[0];
                var selectedPart = (Part)selectedRow.DataBoundItem;

                product.addAssociatedPart(selectedPart);

            }
        }

        private void deleteProductButton_Click(object sender, EventArgs e)
        {
            if (allAssociatedParts.SelectedRows.Count > 0)
            {
                var selectedRow = allAssociatedParts.SelectedRows[0];
                var selectedPart = (Part)selectedRow.DataBoundItem;

                var result = MessageBox.Show("Are you sure you want to remove this part?", "Confirm Remove Selection", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    product.removeAssociatedPart(selectedPart.PartID);
                    MessageBox.Show("Part removed successfully.");
                }
                else
                {
                    MessageBox.Show("Remove cancelled.");
                }
            }
            else
            {
                MessageBox.Show("Associated part is not selected");
            }
        }

        private void candidateParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            allAssociatedParts.ClearSelection();
            allCandidateParts.ClearSelection();
            allCandidateParts.Rows[e.RowIndex].Selected = true;
        }

        private void associatedParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            allCandidateParts.ClearSelection();
            allAssociatedParts.ClearSelection();
            allAssociatedParts.Rows[e.RowIndex].Selected = true;
        }

        private void cancelAddProduct_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void AddProduct_Load(object sender, EventArgs e)
        {

        }

        private void addProductSearchButton_Click(object sender, EventArgs e)
        {
            var itemFound = false;
            var text = addProductSearchBox.Text;
            var isValidNumber = int.TryParse(text, out var partId);
            if (isValidNumber)
            {
                var part = inventory.lookupPart(partId);
                for (int i = allCandidateParts.Rows.Count - 1; i >= 0; i--)
                {
                    var item = allCandidateParts.Rows[i].DataBoundItem as Part;
                    if (allCandidateParts.Rows[i].Selected = item.Equals(part))
                    {
                        itemFound = true;
                    }
                }
            }
            else
            {
                for (int i = allCandidateParts.Rows.Count - 1; i >= 0; i--)
                {
                    var item = allCandidateParts.Rows[i].DataBoundItem as Part;
                    if (allCandidateParts.Rows[i].Selected = !string.IsNullOrEmpty(text) && item.Name.Contains(text, StringComparison.OrdinalIgnoreCase))
                    {
                        itemFound = true;
                    }
                }
            }

            if (!itemFound && !string.IsNullOrEmpty(text))
            {
                MessageBox.Show($"The part with ID or name '{text}' could not be found");
            }
        }
    }
}
