namespace IMS
{
    partial class AddProduct
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
            this.cancelAddProduct = new System.Windows.Forms.Button();
            this.saveAddProduct = new System.Windows.Forms.Button();
            this.addProductMinTextBox = new System.Windows.Forms.TextBox();
            this.addProductMaxTextBox = new System.Windows.Forms.TextBox();
            this.addProductPTextBox = new System.Windows.Forms.TextBox();
            this.addProductInventoryTextBox = new System.Windows.Forms.TextBox();
            this.addProductNameTextBox = new System.Windows.Forms.TextBox();
            this.addProductIDTextBox = new System.Windows.Forms.TextBox();
            this.addProductMaxLabel = new System.Windows.Forms.Label();
            this.addProductPLabel = new System.Windows.Forms.Label();
            this.addProductInventoryLabel = new System.Windows.Forms.Label();
            this.addProductNameLabel = new System.Windows.Forms.Label();
            this.addProductID = new System.Windows.Forms.Label();
            this.addProductTitle = new System.Windows.Forms.Label();
            this.productTL1 = new System.Windows.Forms.Label();
            this.productTL2 = new System.Windows.Forms.Label();
            this.allCandidateParts = new System.Windows.Forms.DataGridView();
            this.allAssociatedParts = new System.Windows.Forms.DataGridView();
            this.deleteProductButton = new System.Windows.Forms.Button();
            this.addProductButton = new System.Windows.Forms.Button();
            this.addProductMin = new System.Windows.Forms.Label();
            this.addProductSearchBox = new System.Windows.Forms.TextBox();
            this.addProductSearchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.allCandidateParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allAssociatedParts)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelAddProduct
            // 
            this.cancelAddProduct.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cancelAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelAddProduct.Location = new System.Drawing.Point(924, 482);
            this.cancelAddProduct.Name = "cancelAddProduct";
            this.cancelAddProduct.Size = new System.Drawing.Size(90, 30);
            this.cancelAddProduct.TabIndex = 30;
            this.cancelAddProduct.Text = "Cancel";
            this.cancelAddProduct.UseVisualStyleBackColor = false;
            this.cancelAddProduct.Click += new System.EventHandler(this.cancelAddProduct_Click);
            // 
            // saveAddProduct
            // 
            this.saveAddProduct.BackColor = System.Drawing.SystemColors.ControlLight;
            this.saveAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveAddProduct.Location = new System.Drawing.Point(819, 482);
            this.saveAddProduct.Name = "saveAddProduct";
            this.saveAddProduct.Size = new System.Drawing.Size(90, 30);
            this.saveAddProduct.TabIndex = 29;
            this.saveAddProduct.Text = "Save";
            this.saveAddProduct.UseVisualStyleBackColor = false;
            this.saveAddProduct.Click += new System.EventHandler(this.saveAddProduct_Click);
            // 
            // addProductMinTextBox
            // 
            this.addProductMinTextBox.Location = new System.Drawing.Point(237, 291);
            this.addProductMinTextBox.Name = "addProductMinTextBox";
            this.addProductMinTextBox.Size = new System.Drawing.Size(70, 20);
            this.addProductMinTextBox.TabIndex = 28;
            // 
            // addProductMaxTextBox
            // 
            this.addProductMaxTextBox.Location = new System.Drawing.Point(95, 290);
            this.addProductMaxTextBox.Name = "addProductMaxTextBox";
            this.addProductMaxTextBox.Size = new System.Drawing.Size(70, 20);
            this.addProductMaxTextBox.TabIndex = 27;
            // 
            // addProductPTextBox
            // 
            this.addProductPTextBox.Location = new System.Drawing.Point(118, 251);
            this.addProductPTextBox.Name = "addProductPTextBox";
            this.addProductPTextBox.Size = new System.Drawing.Size(100, 20);
            this.addProductPTextBox.TabIndex = 26;
            // 
            // addProductInventoryTextBox
            // 
            this.addProductInventoryTextBox.Location = new System.Drawing.Point(118, 211);
            this.addProductInventoryTextBox.Name = "addProductInventoryTextBox";
            this.addProductInventoryTextBox.Size = new System.Drawing.Size(100, 20);
            this.addProductInventoryTextBox.TabIndex = 25;
            // 
            // addProductNameTextBox
            // 
            this.addProductNameTextBox.Location = new System.Drawing.Point(118, 172);
            this.addProductNameTextBox.Name = "addProductNameTextBox";
            this.addProductNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.addProductNameTextBox.TabIndex = 24;
            // 
            // addProductIDTextBox
            // 
            this.addProductIDTextBox.Location = new System.Drawing.Point(118, 137);
            this.addProductIDTextBox.Name = "addProductIDTextBox";
            this.addProductIDTextBox.ReadOnly = true;
            this.addProductIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.addProductIDTextBox.TabIndex = 23;
            // 
            // addProductMaxLabel
            // 
            this.addProductMaxLabel.AutoSize = true;
            this.addProductMaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductMaxLabel.Location = new System.Drawing.Point(45, 290);
            this.addProductMaxLabel.Name = "addProductMaxLabel";
            this.addProductMaxLabel.Size = new System.Drawing.Size(32, 16);
            this.addProductMaxLabel.TabIndex = 22;
            this.addProductMaxLabel.Text = "Max";
            // 
            // addProductPLabel
            // 
            this.addProductPLabel.AutoSize = true;
            this.addProductPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductPLabel.Location = new System.Drawing.Point(45, 252);
            this.addProductPLabel.Name = "addProductPLabel";
            this.addProductPLabel.Size = new System.Drawing.Size(38, 16);
            this.addProductPLabel.TabIndex = 21;
            this.addProductPLabel.Text = "Price";
            // 
            // addProductInventoryLabel
            // 
            this.addProductInventoryLabel.AutoSize = true;
            this.addProductInventoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductInventoryLabel.Location = new System.Drawing.Point(45, 211);
            this.addProductInventoryLabel.Name = "addProductInventoryLabel";
            this.addProductInventoryLabel.Size = new System.Drawing.Size(61, 16);
            this.addProductInventoryLabel.TabIndex = 20;
            this.addProductInventoryLabel.Text = "Inventory";
            // 
            // addProductNameLabel
            // 
            this.addProductNameLabel.AutoSize = true;
            this.addProductNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductNameLabel.Location = new System.Drawing.Point(45, 176);
            this.addProductNameLabel.Name = "addProductNameLabel";
            this.addProductNameLabel.Size = new System.Drawing.Size(44, 16);
            this.addProductNameLabel.TabIndex = 19;
            this.addProductNameLabel.Text = "Name";
            // 
            // addProductID
            // 
            this.addProductID.AutoSize = true;
            this.addProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductID.Location = new System.Drawing.Point(45, 141);
            this.addProductID.Name = "addProductID";
            this.addProductID.Size = new System.Drawing.Size(20, 16);
            this.addProductID.TabIndex = 18;
            this.addProductID.Text = "ID";
            // 
            // addProductTitle
            // 
            this.addProductTitle.AutoSize = true;
            this.addProductTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductTitle.Location = new System.Drawing.Point(13, 9);
            this.addProductTitle.Name = "addProductTitle";
            this.addProductTitle.Size = new System.Drawing.Size(97, 20);
            this.addProductTitle.TabIndex = 17;
            this.addProductTitle.Text = "Add Product";
            // 
            // productTL1
            // 
            this.productTL1.AutoSize = true;
            this.productTL1.Location = new System.Drawing.Point(391, 58);
            this.productTL1.Name = "productTL1";
            this.productTL1.Size = new System.Drawing.Size(96, 13);
            this.productTL1.TabIndex = 31;
            this.productTL1.Text = "All Candidate Parts";
            // 
            // productTL2
            // 
            this.productTL2.AutoSize = true;
            this.productTL2.Location = new System.Drawing.Point(391, 267);
            this.productTL2.Name = "productTL2";
            this.productTL2.Size = new System.Drawing.Size(167, 13);
            this.productTL2.TabIndex = 32;
            this.productTL2.Text = "Parts Associated with this Product";
            // 
            // allCandidateParts
            // 
            this.allCandidateParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allCandidateParts.Location = new System.Drawing.Point(394, 77);
            this.allCandidateParts.Name = "allCandidateParts";
            this.allCandidateParts.Size = new System.Drawing.Size(630, 115);
            this.allCandidateParts.TabIndex = 33;
            this.allCandidateParts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.candidateParts_CellClick);
            // 
            // allAssociatedParts
            // 
            this.allAssociatedParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allAssociatedParts.Location = new System.Drawing.Point(394, 296);
            this.allAssociatedParts.Name = "allAssociatedParts";
            this.allAssociatedParts.Size = new System.Drawing.Size(630, 115);
            this.allAssociatedParts.TabIndex = 34;
            this.allAssociatedParts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.associatedParts_CellClick);
            // 
            // deleteProductButton
            // 
            this.deleteProductButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.deleteProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteProductButton.Location = new System.Drawing.Point(924, 435);
            this.deleteProductButton.Name = "deleteProductButton";
            this.deleteProductButton.Size = new System.Drawing.Size(90, 30);
            this.deleteProductButton.TabIndex = 35;
            this.deleteProductButton.Text = "Remove";
            this.deleteProductButton.UseVisualStyleBackColor = false;
            this.deleteProductButton.Click += new System.EventHandler(this.deleteProductButton_Click);
            // 
            // addProductButton
            // 
            this.addProductButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.addProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductButton.Location = new System.Drawing.Point(924, 211);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(90, 30);
            this.addProductButton.TabIndex = 36;
            this.addProductButton.Text = "Add";
            this.addProductButton.UseVisualStyleBackColor = false;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // addProductMin
            // 
            this.addProductMin.AutoSize = true;
            this.addProductMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductMin.Location = new System.Drawing.Point(190, 291);
            this.addProductMin.Name = "addProductMin";
            this.addProductMin.Size = new System.Drawing.Size(28, 16);
            this.addProductMin.TabIndex = 37;
            this.addProductMin.Text = "Min";
            // 
            // addProductSearchBox
            // 
            this.addProductSearchBox.Location = new System.Drawing.Point(838, 36);
            this.addProductSearchBox.Name = "addProductSearchBox";
            this.addProductSearchBox.Size = new System.Drawing.Size(186, 20);
            this.addProductSearchBox.TabIndex = 39;
            // 
            // addProductSearchButton
            // 
            this.addProductSearchButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.addProductSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addProductSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductSearchButton.Location = new System.Drawing.Point(728, 30);
            this.addProductSearchButton.Name = "addProductSearchButton";
            this.addProductSearchButton.Size = new System.Drawing.Size(90, 30);
            this.addProductSearchButton.TabIndex = 40;
            this.addProductSearchButton.Text = "Search";
            this.addProductSearchButton.UseVisualStyleBackColor = false;
            this.addProductSearchButton.Click += new System.EventHandler(this.addProductSearchButton_Click);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 560);
            this.Controls.Add(this.addProductSearchButton);
            this.Controls.Add(this.addProductSearchBox);
            this.Controls.Add(this.addProductMin);
            this.Controls.Add(this.addProductButton);
            this.Controls.Add(this.deleteProductButton);
            this.Controls.Add(this.allAssociatedParts);
            this.Controls.Add(this.allCandidateParts);
            this.Controls.Add(this.productTL2);
            this.Controls.Add(this.productTL1);
            this.Controls.Add(this.cancelAddProduct);
            this.Controls.Add(this.saveAddProduct);
            this.Controls.Add(this.addProductMinTextBox);
            this.Controls.Add(this.addProductMaxTextBox);
            this.Controls.Add(this.addProductPTextBox);
            this.Controls.Add(this.addProductInventoryTextBox);
            this.Controls.Add(this.addProductNameTextBox);
            this.Controls.Add(this.addProductIDTextBox);
            this.Controls.Add(this.addProductMaxLabel);
            this.Controls.Add(this.addProductPLabel);
            this.Controls.Add(this.addProductInventoryLabel);
            this.Controls.Add(this.addProductNameLabel);
            this.Controls.Add(this.addProductID);
            this.Controls.Add(this.addProductTitle);
            this.Name = "AddProduct";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.addProductIDIncrement);
            ((System.ComponentModel.ISupportInitialize)(this.allCandidateParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allAssociatedParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelAddProduct;
        private System.Windows.Forms.Button saveAddProduct;
        private System.Windows.Forms.TextBox addProductMinTextBox;
        private System.Windows.Forms.TextBox addProductMaxTextBox;
        private System.Windows.Forms.TextBox addProductPTextBox;
        private System.Windows.Forms.TextBox addProductInventoryTextBox;
        private System.Windows.Forms.TextBox addProductNameTextBox;
        private System.Windows.Forms.TextBox addProductIDTextBox;
        private System.Windows.Forms.Label addProductMaxLabel;
        private System.Windows.Forms.Label addProductPLabel;
        private System.Windows.Forms.Label addProductInventoryLabel;
        private System.Windows.Forms.Label addProductNameLabel;
        private System.Windows.Forms.Label addProductID;
        private System.Windows.Forms.Label addProductTitle;
        private System.Windows.Forms.Label productTL1;
        private System.Windows.Forms.Label productTL2;
        private System.Windows.Forms.DataGridView allCandidateParts;
        private System.Windows.Forms.DataGridView allAssociatedParts;
        private System.Windows.Forms.Button deleteProductButton;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Label addProductMin;
        private System.Windows.Forms.TextBox addProductSearchBox;
        private System.Windows.Forms.Button addProductSearchButton;
    }
}