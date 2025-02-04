using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IMS.Models;

namespace IMS
{
    public partial class ModifyPart : Form
    {
        private Inventory inventory;
        private Part selectedPart;

        public ModifyPart(Outsourced outsourced, Inventory inventory)
        {
            InitializeComponent();
            this.inventory = inventory;
            this.selectedPart = outsourced;
            modifyPartMIDLabel.Text = "Company Name";

            openOutsourcedForm(outsourced);
        }

        public ModifyPart(InHouse inHouse, Inventory inventory)
        {
            InitializeComponent();
            this.inventory = inventory;
            this.selectedPart = inHouse;
            modifyPartMIDLabel.Text = "Machine ID";

            openInHouseForm(inHouse);
        }

        private void openInHouseForm(InHouse inHouse)
        {
            modifyPartMIDTextBox.Visible = true;
            modifyPartInH.Checked = true;

            modifyPartMIDTextBox.Text = inHouse.MachineID.ToString();
            modifyPartMinTextBox.Text = inHouse.Min.ToString();
            modifyPartMaxTextBox.Text = inHouse.Max.ToString();
            modifyPartPCTextBox.Text = inHouse.Price.ToString();
            modifyPartInventoryTextBox.Text = inHouse.InStock.ToString();
            modifyPartIDTextBox.Text = inHouse.PartID.ToString();
            modifyPartNameTextBox.Text = inHouse.Name;
        }

        private void openOutsourcedForm(Outsourced outsourced)
        {
            modifyPartOSTextBox.Visible = true;
            modifyPartOuts.Checked = true;

            modifyPartOSTextBox.Text = outsourced.CompanyName;
            modifyPartMinTextBox.Text = outsourced.Min.ToString();
            modifyPartMaxTextBox.Text = outsourced.Max.ToString();
            modifyPartPCTextBox.Text = outsourced.Price.ToString();
            modifyPartInventoryTextBox.Text = outsourced.InStock.ToString();
            modifyPartIDTextBox.Text = outsourced.PartID.ToString();
            modifyPartNameTextBox.Text = outsourced.Name;

        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (modifyPartInH.Checked)
            {
                modifyPartMIDLabel.Text = "Machine ID";
                modifyPartMIDTextBox.Visible = true;
                modifyPartOSTextBox.Visible = false;
            }
            else if (modifyPartOuts.Checked)
            {
                modifyPartMIDLabel.Text = "Company Name";
                modifyPartOSTextBox.Visible = true;
                modifyPartMIDTextBox.Visible = false;
            }
        }

        private void saveModifyPart_Click(object sender, EventArgs e)
        {
            string partName = modifyPartNameTextBox.Text;
            if (string.IsNullOrWhiteSpace(partName))
            {
                MessageBox.Show("Part name cannot be empty");
                return;
            }
            if (int.TryParse(modifyPartInventoryTextBox.Text, out int InStock) == false)
            {
                MessageBox.Show("Inventory is not a valid integer");
                return;
            }
            if (decimal.TryParse(modifyPartPCTextBox.Text, out decimal Price) == false)
            {
                MessageBox.Show("Price is not a valid decimal");
                return;
            }
            if (int.TryParse(modifyPartMinTextBox.Text, out int Min) == false)
            {
                MessageBox.Show("Min is not a valid integer");
                return;
            }
            if (int.TryParse(modifyPartMaxTextBox.Text, out int Max) == false)
            {
                MessageBox.Show("Max is not a valid integer");
                return;
            }
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

            if (modifyPartInH.Checked)
            {
                if (int.TryParse(modifyPartMIDTextBox.Text, out int machineID) == false)
                {
                    MessageBox.Show("Machine ID is not a valid integer");
                    return;
                }

                InHouse newPart = new InHouse
                {
                    Name = partName,
                    Price = Price,
                    InStock = InStock,
                    Min = Min,
                    Max = Max,
                    MachineID = machineID
                };

                inventory.updatePart(selectedPart.PartID, newPart);
            }

            else if (modifyPartOuts.Checked)
            {
                string companyName = modifyPartOSTextBox.Text;
                if (string.IsNullOrWhiteSpace(companyName))
                {
                    MessageBox.Show("Company name cannot be empty");
                    return;
                }

                Outsourced newPart = new Outsourced
                {
                    Name = partName,
                    Price = Price,
                    InStock = InStock,
                    Min = Min,
                    Max = Max,
                    CompanyName = companyName
                };

                inventory.updatePart(selectedPart.PartID, newPart);
            }

            this.Close();

    }

        private void cancelModifyPart_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
