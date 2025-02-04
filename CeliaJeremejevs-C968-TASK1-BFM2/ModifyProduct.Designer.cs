namespace IMS
{
    partial class ModifyProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.modifyProductSearchButton = new System.Windows.Forms.Button();
            this.modifyProductSearchBox = new System.Windows.Forms.TextBox();
            this.modifyProductMin = new System.Windows.Forms.Label();
            this.addProductButton = new System.Windows.Forms.Button();
            this.deleteProductButton = new System.Windows.Forms.Button();
            this.allAssociatedParts = new System.Windows.Forms.DataGridView();
            this.allCandidateParts = new System.Windows.Forms.DataGridView();
            this.productTL2 = new System.Windows.Forms.Label();
            this.productTL1 = new System.Windows.Forms.Label();
            this.cancelAddProduct = new System.Windows.Forms.Button();
            this.saveAddProduct = new System.Windows.Forms.Button();
            this.modifyProductMinTextBox = new System.Windows.Forms.TextBox();
            this.modifyProductMaxTextBox = new System.Windows.Forms.TextBox();
            this.modifyProductPTextBox = new System.Windows.Forms.TextBox();
            this.modifyProductInventoryTextBox = new System.Windows.Forms.TextBox();
            this.modifyProductNameTextBox = new System.Windows.Forms.TextBox();
            this.modifyProductIDTextBox = new System.Windows.Forms.TextBox();
            this.modifyProductMaxLabel = new System.Windows.Forms.Label();
            this.modifyProductPLabel = new System.Windows.Forms.Label();
            this.modifyProductInventoryLabel = new System.Windows.Forms.Label();
            this.modifyProductNameLabel = new System.Windows.Forms.Label();
            this.modifyProductID = new System.Windows.Forms.Label();
            this.modifyProductTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.allAssociatedParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allCandidateParts)).BeginInit();
            this.SuspendLayout();
            // 
            // modifyProductSearchButton
            // 
            this.modifyProductSearchButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.modifyProductSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.modifyProductSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyProductSearchButton.Location = new System.Drawing.Point(728, 31);
            this.modifyProductSearchButton.Name = "modifyProductSearchButton";
            this.modifyProductSearchButton.Size = new System.Drawing.Size(90, 30);
            this.modifyProductSearchButton.TabIndex = 63;
            this.modifyProductSearchButton.Text = "Search";
            this.modifyProductSearchButton.UseVisualStyleBackColor = false;
            this.modifyProductSearchButton.Click += new System.EventHandler(this.modifyProductSearchButton_Click);
            // 
            // modifyProductSearchBox
            // 
            this.modifyProductSearchBox.Location = new System.Drawing.Point(838, 37);
            this.modifyProductSearchBox.Name = "modifyProductSearchBox";
            this.modifyProductSearchBox.Size = new System.Drawing.Size(186, 20);
            this.modifyProductSearchBox.TabIndex = 62;
            // 
            // modifyProductMin
            // 
            this.modifyProductMin.AutoSize = true;
            this.modifyProductMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyProductMin.Location = new System.Drawing.Point(190, 292);
            this.modifyProductMin.Name = "modifyProductMin";
            this.modifyProductMin.Size = new System.Drawing.Size(28, 16);
            this.modifyProductMin.TabIndex = 61;
            this.modifyProductMin.Text = "Min";
            // 
            // addProductButton
            // 
            this.addProductButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.addProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductButton.Location = new System.Drawing.Point(924, 212);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(90, 30);
            this.addProductButton.TabIndex = 60;
            this.addProductButton.Text = "Add";
            this.addProductButton.UseVisualStyleBackColor = false;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // deleteProductButton
            // 
            this.deleteProductButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.deleteProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteProductButton.Location = new System.Drawing.Point(924, 436);
            this.deleteProductButton.Name = "deleteProductButton";
            this.deleteProductButton.Size = new System.Drawing.Size(90, 30);
            this.deleteProductButton.TabIndex = 59;
            this.deleteProductButton.Text = "Remove";
            this.deleteProductButton.UseVisualStyleBackColor = false;
            this.deleteProductButton.Click += new System.EventHandler(this.deleteProductButton_Click);
            // 
            // allAssociatedParts
            // 
            this.allAssociatedParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allAssociatedParts.Location = new System.Drawing.Point(394, 297);
            this.allAssociatedParts.Name = "allAssociatedParts";
            this.allAssociatedParts.Size = new System.Drawing.Size(630, 115);
            this.allAssociatedParts.TabIndex = 58;
            this.allAssociatedParts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.modifyAssociatedParts_CellClick);
            // 
            // allCandidateParts
            // 
            this.allCandidateParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allCandidateParts.Location = new System.Drawing.Point(394, 78);
            this.allCandidateParts.Name = "allCandidateParts";
            this.allCandidateParts.Size = new System.Drawing.Size(630, 115);
            this.allCandidateParts.TabIndex = 57;
            this.allCandidateParts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.modifyCandidateParts_CellClick);
            // 
            // productTL2
            // 
            this.productTL2.AutoSize = true;
            this.productTL2.Location = new System.Drawing.Point(391, 268);
            this.productTL2.Name = "productTL2";
            this.productTL2.Size = new System.Drawing.Size(167, 13);
            this.productTL2.TabIndex = 56;
            this.productTL2.Text = "Parts Associated with this Product";
            // 
            // productTL1
            // 
            this.productTL1.AutoSize = true;
            this.productTL1.Location = new System.Drawing.Point(391, 59);
            this.productTL1.Name = "productTL1";
            this.productTL1.Size = new System.Drawing.Size(96, 13);
            this.productTL1.TabIndex = 55;
            this.productTL1.Text = "All Candidate Parts";
            // 
            // cancelAddProduct
            // 
            this.cancelAddProduct.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cancelAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelAddProduct.Location = new System.Drawing.Point(924, 483);
            this.cancelAddProduct.Name = "cancelAddProduct";
            this.cancelAddProduct.Size = new System.Drawing.Size(90, 30);
            this.cancelAddProduct.TabIndex = 54;
            this.cancelAddProduct.Text = "Cancel";
            this.cancelAddProduct.UseVisualStyleBackColor = false;
            this.cancelAddProduct.Click += new System.EventHandler(this.cancelAddProduct_Click);
            // 
            // saveAddProduct
            // 
            this.saveAddProduct.BackColor = System.Drawing.SystemColors.ControlLight;
            this.saveAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveAddProduct.Location = new System.Drawing.Point(819, 483);
            this.saveAddProduct.Name = "saveAddProduct";
            this.saveAddProduct.Size = new System.Drawing.Size(90, 30);
            this.saveAddProduct.TabIndex = 53;
            this.saveAddProduct.Text = "Save";
            this.saveAddProduct.UseVisualStyleBackColor = false;
            this.saveAddProduct.Click += new System.EventHandler(this.saveAddProduct_Click);
            // 
            // modifyProductMinTextBox
            // 
            this.modifyProductMinTextBox.Location = new System.Drawing.Point(237, 292);
            this.modifyProductMinTextBox.Name = "modifyProductMinTextBox";
            this.modifyProductMinTextBox.Size = new System.Drawing.Size(70, 20);
            this.modifyProductMinTextBox.TabIndex = 52;
            // 
            // modifyProductMaxTextBox
            // 
            this.modifyProductMaxTextBox.Location = new System.Drawing.Point(95, 291);
            this.modifyProductMaxTextBox.Name = "modifyProductMaxTextBox";
            this.modifyProductMaxTextBox.Size = new System.Drawing.Size(70, 20);
            this.modifyProductMaxTextBox.TabIndex = 51;
            // 
            // modifyProductPTextBox
            // 
            this.modifyProductPTextBox.Location = new System.Drawing.Point(118, 252);
            this.modifyProductPTextBox.Name = "modifyProductPTextBox";
            this.modifyProductPTextBox.Size = new System.Drawing.Size(100, 20);
            this.modifyProductPTextBox.TabIndex = 50;
            // 
            // modifyProductInventoryTextBox
            // 
            this.modifyProductInventoryTextBox.Location = new System.Drawing.Point(118, 212);
            this.modifyProductInventoryTextBox.Name = "modifyProductInventoryTextBox";
            this.modifyProductInventoryTextBox.Size = new System.Drawing.Size(100, 20);
            this.modifyProductInventoryTextBox.TabIndex = 49;
            // 
            // modifyProductNameTextBox
            // 
            this.modifyProductNameTextBox.Location = new System.Drawing.Point(118, 173);
            this.modifyProductNameTextBox.Name = "modifyProductNameTextBox";
            this.modifyProductNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.modifyProductNameTextBox.TabIndex = 48;
            // 
            // modifyProductIDTextBox
            // 
            this.modifyProductIDTextBox.Location = new System.Drawing.Point(118, 138);
            this.modifyProductIDTextBox.Name = "modifyProductIDTextBox";
            this.modifyProductIDTextBox.ReadOnly = true;
            this.modifyProductIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.modifyProductIDTextBox.TabIndex = 47;
            // 
            // modifyProductMaxLabel
            // 
            this.modifyProductMaxLabel.AutoSize = true;
            this.modifyProductMaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyProductMaxLabel.Location = new System.Drawing.Point(45, 291);
            this.modifyProductMaxLabel.Name = "modifyProductMaxLabel";
            this.modifyProductMaxLabel.Size = new System.Drawing.Size(32, 16);
            this.modifyProductMaxLabel.TabIndex = 46;
            this.modifyProductMaxLabel.Text = "Max";
            // 
            // modifyProductPLabel
            // 
            this.modifyProductPLabel.AutoSize = true;
            this.modifyProductPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyProductPLabel.Location = new System.Drawing.Point(45, 253);
            this.modifyProductPLabel.Name = "modifyProductPLabel";
            this.modifyProductPLabel.Size = new System.Drawing.Size(38, 16);
            this.modifyProductPLabel.TabIndex = 45;
            this.modifyProductPLabel.Text = "Price";
            // 
            // modifyProductInventoryLabel
            // 
            this.modifyProductInventoryLabel.AutoSize = true;
            this.modifyProductInventoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyProductInventoryLabel.Location = new System.Drawing.Point(45, 212);
            this.modifyProductInventoryLabel.Name = "modifyProductInventoryLabel";
            this.modifyProductInventoryLabel.Size = new System.Drawing.Size(61, 16);
            this.modifyProductInventoryLabel.TabIndex = 44;
            this.modifyProductInventoryLabel.Text = "Inventory";
            // 
            // modifyProductNameLabel
            // 
            this.modifyProductNameLabel.AutoSize = true;
            this.modifyProductNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyProductNameLabel.Location = new System.Drawing.Point(45, 177);
            this.modifyProductNameLabel.Name = "modifyProductNameLabel";
            this.modifyProductNameLabel.Size = new System.Drawing.Size(44, 16);
            this.modifyProductNameLabel.TabIndex = 43;
            this.modifyProductNameLabel.Text = "Name";
            // 
            // modifyProductID
            // 
            this.modifyProductID.AutoSize = true;
            this.modifyProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyProductID.Location = new System.Drawing.Point(45, 142);
            this.modifyProductID.Name = "modifyProductID";
            this.modifyProductID.Size = new System.Drawing.Size(20, 16);
            this.modifyProductID.TabIndex = 42;
            this.modifyProductID.Text = "ID";
            // 
            // modifyProductTitle
            // 
            this.modifyProductTitle.AutoSize = true;
            this.modifyProductTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyProductTitle.Location = new System.Drawing.Point(13, 10);
            this.modifyProductTitle.Name = "modifyProductTitle";
            this.modifyProductTitle.Size = new System.Drawing.Size(114, 20);
            this.modifyProductTitle.TabIndex = 41;
            this.modifyProductTitle.Text = "Modify Product";
            // 
            // ModifyProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 560);
            this.Controls.Add(this.modifyProductSearchButton);
            this.Controls.Add(this.modifyProductSearchBox);
            this.Controls.Add(this.modifyProductMin);
            this.Controls.Add(this.addProductButton);
            this.Controls.Add(this.deleteProductButton);
            this.Controls.Add(this.allAssociatedParts);
            this.Controls.Add(this.allCandidateParts);
            this.Controls.Add(this.productTL2);
            this.Controls.Add(this.productTL1);
            this.Controls.Add(this.cancelAddProduct);
            this.Controls.Add(this.saveAddProduct);
            this.Controls.Add(this.modifyProductMinTextBox);
            this.Controls.Add(this.modifyProductMaxTextBox);
            this.Controls.Add(this.modifyProductPTextBox);
            this.Controls.Add(this.modifyProductInventoryTextBox);
            this.Controls.Add(this.modifyProductNameTextBox);
            this.Controls.Add(this.modifyProductIDTextBox);
            this.Controls.Add(this.modifyProductMaxLabel);
            this.Controls.Add(this.modifyProductPLabel);
            this.Controls.Add(this.modifyProductInventoryLabel);
            this.Controls.Add(this.modifyProductNameLabel);
            this.Controls.Add(this.modifyProductID);
            this.Controls.Add(this.modifyProductTitle);
            this.Name = "ModifyProduct";
            this.Text = "ModifyProduct";
            ((System.ComponentModel.ISupportInitialize)(this.allAssociatedParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allCandidateParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button modifyProductSearchButton;
        private System.Windows.Forms.TextBox modifyProductSearchBox;
        private System.Windows.Forms.Label modifyProductMin;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Button deleteProductButton;
        private System.Windows.Forms.DataGridView allAssociatedParts;
        private System.Windows.Forms.DataGridView allCandidateParts;
        private System.Windows.Forms.Label productTL2;
        private System.Windows.Forms.Label productTL1;
        private System.Windows.Forms.Button cancelAddProduct;
        private System.Windows.Forms.Button saveAddProduct;
        private System.Windows.Forms.TextBox modifyProductMinTextBox;
        private System.Windows.Forms.TextBox modifyProductMaxTextBox;
        private System.Windows.Forms.TextBox modifyProductPTextBox;
        private System.Windows.Forms.TextBox modifyProductInventoryTextBox;
        private System.Windows.Forms.TextBox modifyProductNameTextBox;
        private System.Windows.Forms.TextBox modifyProductIDTextBox;
        private System.Windows.Forms.Label modifyProductMaxLabel;
        private System.Windows.Forms.Label modifyProductPLabel;
        private System.Windows.Forms.Label modifyProductInventoryLabel;
        private System.Windows.Forms.Label modifyProductNameLabel;
        private System.Windows.Forms.Label modifyProductID;
        private System.Windows.Forms.Label modifyProductTitle;
    }
}