using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IMS.Models;

namespace IMS
{
    public partial class AddPart : Form
    {

        private Inventory inventory;

        public AddPart(Inventory inventory)
        {
            InitializeComponent();
            this.inventory = inventory;
            if (addPartInH.Checked)
            {
                addPartCNLabel.Text = "Machine ID";
                addPartCNTextBox.Visible = true;
            }
        }

        private void addPartIDIncrement(object sender, EventArgs e)
        {
            int partID = 1;

            if (inventory.AllParts.Count != 0)
            {
                partID = inventory.AllParts.Max(part => part.PartID) + 1;
            }

            addPartIDTextBox.Text = partID.ToString();
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (addPartInH.Checked)
            {
                addPartCNLabel.Text = "Machine ID";
                addPartCNTextBox.Visible = true;
                addPartOSTextBox.Visible = false;
            }
            else if (addPartOuts.Checked)
            {
                addPartCNLabel.Text = "Company Name";
                addPartOSTextBox.Visible = true;
                addPartCNTextBox.Visible = false;
            }
        }

        private void saveAddPart_Click(object sender, EventArgs e)
        {
            if (int.TryParse(addPartIDTextBox.Text, out int partID) == false) {
                MessageBox.Show("Part ID is not a valid integer");
                return;
            }
            string partName = addPartNameTextBox.Text;
            if (string.IsNullOrWhiteSpace(partName))
            {
                MessageBox.Show("Part name cannot be empty");
                return;
            }
            if (int.TryParse(addPartInventoryTextBox.Text, out int InStock) == false)
            {
                MessageBox.Show("Inventory is not a valid integer");
                return;
            }
            if (decimal.TryParse(addPartPCTextBox.Text, out decimal Price) == false)
            {
                MessageBox.Show("Price is not a valid decimal");
                return;
            }
            if (int.TryParse(addPartMinTextBox.Text, out int Min) == false)
            {
                MessageBox.Show("Min is not a valid integer");
                return;
            }
            if (int.TryParse(addPartMaxTextBox.Text, out int Max) == false)
            {
                MessageBox.Show("Max is not a valid integer");
                return;
            }
            if (Min > Max) {
                MessageBox.Show("Min is higher than Max");
                return;
            }
            if (InStock < Min || InStock > Max)
            {
                MessageBox.Show("Inventory is outside of Min/Max range");
                return;
            }

            if (addPartOuts.Checked)
            {
                string companyName = addPartOSTextBox.Text;
                if (string.IsNullOrWhiteSpace(companyName))
                {
                    MessageBox.Show("Company name cannot be empty");
                    return;
                }
                Outsourced newPart = new Outsourced
                {
                    PartID = partID,
                    Name = partName,
                    Price = Price,
                    InStock = InStock,
                    Min = Min,
                    Max = Max,
                    CompanyName = companyName,
                };

                inventory.addPart(newPart);

                this.Close();
            }

            else if (addPartInH.Checked)
            {
                if (int.TryParse(addPartCNTextBox.Text, out int machineID) == false)
                {
                    MessageBox.Show("Machine ID is not a valid integer");
                    return;
                }

                InHouse newPart = new InHouse
                {
                    PartID = partID,
                    Name = partName,
                    Price = Price,
                    InStock = InStock,
                    Min = Min,
                    Max = Max,
                    MachineID = machineID,
                };

                inventory.addPart(newPart);

                this.Close();
            }
    }

        private void cancelAddPart_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addPartPCTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
