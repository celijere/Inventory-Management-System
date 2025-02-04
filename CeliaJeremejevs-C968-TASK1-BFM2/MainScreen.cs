using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IMS.Extensions;
using IMS.Models;

namespace IMS
{
    public partial class MainScreen : Form
    {

        private Inventory inventory;

        public MainScreen()
        {
            InitializeComponent();

            inventory = new Inventory();

            partsGrid.DataSource = inventory.AllParts;
            productsGrid.DataSource = inventory.Products;

            inventory.AllParts.ListChanged += PartListUpdateHandler;
            inventory.Products.ListChanged += ProductsListUpdateHandler;
        }

        private void PartsModifyButton_Click(object sender, EventArgs e)
        {

            if (partsGrid.SelectedRows.Count > 0)
            {
                var selectedRow = partsGrid.SelectedRows[0];
                var selectedPart = (Part)selectedRow.DataBoundItem;

                if (selectedPart is InHouse inHouse)
                {

                    ModifyPart modifyPart = new ModifyPart(inHouse, inventory);
                    modifyPart.ShowDialog();
                }

                else if (selectedPart is Outsourced outsourced)
                {

                    ModifyPart modifyPart = new ModifyPart(outsourced, inventory);
                    modifyPart.ShowDialog();
                }

            }
        }

        private void PartListUpdateHandler(object sender, ListChangedEventArgs e)
        {

            if (e.ListChangedType == ListChangedType.ItemChanged)
            {
                partsGrid.Refresh();
            }

            else if (e.ListChangedType == ListChangedType.ItemAdded)
            {
                partsGrid.Refresh();
            }

            else if (e.ListChangedType == ListChangedType.ItemDeleted)
            {
                partsGrid.Refresh();
            }
        }

        private void ProductsListUpdateHandler(object sender, ListChangedEventArgs e)
        {

            if (e.ListChangedType == ListChangedType.ItemChanged)
            {
                productsGrid.Refresh();
            }

            else if (e.ListChangedType == ListChangedType.ItemAdded)
            {
                productsGrid.Refresh();
            }

            else if (e.ListChangedType == ListChangedType.ItemDeleted)
            {
                productsGrid.Refresh();
            }
        }

        private void PartsDelButton_Click(object sender, EventArgs e)
        {

            if (partsGrid.SelectedRows.Count > 0)
            {
                var selectedRow = partsGrid.SelectedRows[0];
                var selectedPart = (Part)selectedRow.DataBoundItem;

                int partIndex = selectedPart.PartID;

                bool foundAssociatedPart = inventory.Products.Any(
                    part => part.AssociatedParts.Any(associatedPart => associatedPart.PartID == partIndex)
                );

                if (!foundAssociatedPart)
                {
                    var result = MessageBox.Show("Are you sure you want to delete this part?", "Confirm Deletion Selection", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        inventory.deletePart(selectedPart);
                        MessageBox.Show("Part deleted successfully.");
                    }

                    else
                    {
                        MessageBox.Show("Deletion cancelled.");
                    }
                }

                else {
                    MessageBox.Show("Cannot delete a part that is associated with a product");
                }
            }
        }
            


        private void PartsAddButton_Click(object sender, EventArgs e)
        {
            AddPart addPart = new AddPart(inventory);
            addPart.Show();

        }

        private void PartsSearchButton_Click(object sender, EventArgs e)
        {
            var itemFound = false;
            var text = partsSearch.Text;
            var isValidNumber = int.TryParse(text, out var partId);
            if (isValidNumber)
            {
                var part = inventory.lookupPart(partId);
                for (int i = partsGrid.Rows.Count - 1; i >= 0; i--) {
                    var item = partsGrid.Rows[i].DataBoundItem as Part;
                    if (partsGrid.Rows[i].Selected = item.Equals(part)) {
                        itemFound = true;
                    }
                }
            } 
            else
            {
                for (int i = partsGrid.Rows.Count - 1; i >= 0; i--) {
                    var item = partsGrid.Rows[i].DataBoundItem as Part;
                    if (partsGrid.Rows[i].Selected = !string.IsNullOrEmpty(text) && item.Name.Contains(text, StringComparison.OrdinalIgnoreCase)){
                        itemFound = true;
                    }
                }
            }

            if (!itemFound && !string.IsNullOrEmpty(text))
            {
                MessageBox.Show($"The part with ID or name '{text}' could not be found");
            }
        }

        private void ProductsAddButton(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct(inventory);
            addProduct.Show();
        }

        private void ProductsModifyButton(object sender, EventArgs e)
        {

            if (productsGrid.SelectedRows.Count > 0)
            {
                var selectedRow = productsGrid.SelectedRows[0];
                var selectedProduct = (Product)selectedRow.DataBoundItem;

                ModifyProduct modifyProduct = new ModifyProduct(inventory, selectedProduct);
                modifyProduct.Show();
            }

            else
            {
                MessageBox.Show("Please select a product to modify");
            }

        }

        private void ProductsDelButton_Click(object sender, EventArgs e)
        {
            if (productsGrid.SelectedRows.Count > 0)
            {
                var selectedRow = productsGrid.SelectedRows[0];
                var selectedProduct = (Product)selectedRow.DataBoundItem;

                int productIndex = selectedProduct.ProductID;
                

                if (selectedProduct.AssociatedParts.Any())
                {
                    MessageBox.Show("Cannot delete a product that is associated with a part");
                }
                else {
                    var result = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Deletion Selection", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        inventory.removeProduct(productIndex);
                        MessageBox.Show("Product deleted successfully.");
                    }

                    else
                    {
                        MessageBox.Show("Deletion cancelled.");
                    }
                }
                }
            }


        private void ProductsSearchButton_Click(object sender, EventArgs e)
        {
            var itemFound = false;
            var text = productsSearch.Text;
            var isValidNumber = int.TryParse(text, out var productId);
            if (isValidNumber)
            {
                var product = inventory.lookupProduct(productId);
                for (int i = productsGrid.Rows.Count - 1; i >= 0; i--)
                {
                    var item = productsGrid.Rows[i].DataBoundItem as Product;
                    if (productsGrid.Rows[i].Selected = item.Equals(product))
                    {
                        itemFound = true;
                    }
                }
            }
            else
            {
                for (int i = productsGrid.Rows.Count - 1; i >= 0; i--)
                {
                    var item = productsGrid.Rows[i].DataBoundItem as Product;
                    if (productsGrid.Rows[i].Selected = !string.IsNullOrEmpty(text) && item.Name.Contains(text, StringComparison.OrdinalIgnoreCase))
                    {
                        itemFound = true;
                    }
                }
            }

            if (!itemFound && !string.IsNullOrEmpty(text))
            {
                MessageBox.Show($"The product with ID or name '{text}' could not be found");
            }
        }

        private void partsSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void productsSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void partsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearSelection();
            partsGrid.Rows[e.RowIndex].Selected = true;
        }

        private void productsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearSelection();
            productsGrid.Rows[e.RowIndex].Selected = true;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearSelection()
        {
            productsGrid.ClearSelection();
            partsGrid.ClearSelection();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
