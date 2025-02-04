using IMS.Models;

namespace IMS
{
    partial class MainScreen
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
            this.mainTitle = new System.Windows.Forms.Label();
            this.partsSearchButton = new System.Windows.Forms.Button();
            this.partsAddButton = new System.Windows.Forms.Button();
            this.partsModifyButton = new System.Windows.Forms.Button();
            this.partsDelButton = new System.Windows.Forms.Button();
            this.productsAddButton = new System.Windows.Forms.Button();
            this.productsModifyButton = new System.Windows.Forms.Button();
            this.productsDelButton = new System.Windows.Forms.Button();
            this.productsSearchButton = new System.Windows.Forms.Button();
            this.partsTitle = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.productsTitle = new System.Windows.Forms.Label();
            this.partsSearch = new System.Windows.Forms.TextBox();
            this.productsSearch = new System.Windows.Forms.TextBox();
            this.partsGrid = new System.Windows.Forms.DataGridView();
            this.productsGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.partsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTitle
            // 
            this.mainTitle.AutoSize = true;
            this.mainTitle.Location = new System.Drawing.Point(12, 9);
            this.mainTitle.Name = "mainTitle";
            this.mainTitle.Size = new System.Drawing.Size(153, 13);
            this.mainTitle.TabIndex = 0;
            this.mainTitle.Text = "Inventory Management System";
            // 
            // partsSearchButton
            // 
            this.partsSearchButton.Location = new System.Drawing.Point(189, 37);
            this.partsSearchButton.Name = "partsSearchButton";
            this.partsSearchButton.Size = new System.Drawing.Size(75, 23);
            this.partsSearchButton.TabIndex = 1;
            this.partsSearchButton.Text = "Search";
            this.partsSearchButton.UseVisualStyleBackColor = true;
            this.partsSearchButton.Click += new System.EventHandler(this.PartsSearchButton_Click);
            // 
            // partsAddButton
            // 
            this.partsAddButton.Location = new System.Drawing.Point(401, 221);
            this.partsAddButton.Name = "partsAddButton";
            this.partsAddButton.Size = new System.Drawing.Size(75, 23);
            this.partsAddButton.TabIndex = 2;
            this.partsAddButton.Text = "Add";
            this.partsAddButton.UseVisualStyleBackColor = true;
            this.partsAddButton.Click += new System.EventHandler(this.PartsAddButton_Click);
            // 
            // partsModifyButton
            // 
            this.partsModifyButton.Location = new System.Drawing.Point(482, 221);
            this.partsModifyButton.Name = "partsModifyButton";
            this.partsModifyButton.Size = new System.Drawing.Size(75, 23);
            this.partsModifyButton.TabIndex = 3;
            this.partsModifyButton.Text = "Modify";
            this.partsModifyButton.UseVisualStyleBackColor = true;
            this.partsModifyButton.Click += new System.EventHandler(this.PartsModifyButton_Click);
            // 
            // partsDelButton
            // 
            this.partsDelButton.Location = new System.Drawing.Point(563, 221);
            this.partsDelButton.Name = "partsDelButton";
            this.partsDelButton.Size = new System.Drawing.Size(75, 23);
            this.partsDelButton.TabIndex = 4;
            this.partsDelButton.Text = "Delete";
            this.partsDelButton.UseVisualStyleBackColor = true;
            this.partsDelButton.Click += new System.EventHandler(this.PartsDelButton_Click);
            // 
            // productsAddButton
            // 
            this.productsAddButton.Location = new System.Drawing.Point(1075, 223);
            this.productsAddButton.Name = "productsAddButton";
            this.productsAddButton.Size = new System.Drawing.Size(75, 23);
            this.productsAddButton.TabIndex = 5;
            this.productsAddButton.Text = "Add";
            this.productsAddButton.UseVisualStyleBackColor = true;
            this.productsAddButton.Click += new System.EventHandler(this.ProductsAddButton);
            // 
            // productsModifyButton
            // 
            this.productsModifyButton.Location = new System.Drawing.Point(1156, 223);
            this.productsModifyButton.Name = "productsModifyButton";
            this.productsModifyButton.Size = new System.Drawing.Size(75, 23);
            this.productsModifyButton.TabIndex = 6;
            this.productsModifyButton.Text = "Modify";
            this.productsModifyButton.UseVisualStyleBackColor = true;
            this.productsModifyButton.Click += new System.EventHandler(this.ProductsModifyButton);
            // 
            // productsDelButton
            // 
            this.productsDelButton.Location = new System.Drawing.Point(1237, 223);
            this.productsDelButton.Name = "productsDelButton";
            this.productsDelButton.Size = new System.Drawing.Size(75, 23);
            this.productsDelButton.TabIndex = 7;
            this.productsDelButton.Text = "Delete";
            this.productsDelButton.UseVisualStyleBackColor = true;
            this.productsDelButton.Click += new System.EventHandler(this.ProductsDelButton_Click);
            // 
            // productsSearchButton
            // 
            this.productsSearchButton.Location = new System.Drawing.Point(873, 39);
            this.productsSearchButton.Name = "productsSearchButton";
            this.productsSearchButton.Size = new System.Drawing.Size(75, 23);
            this.productsSearchButton.TabIndex = 8;
            this.productsSearchButton.Text = "Search";
            this.productsSearchButton.UseVisualStyleBackColor = true;
            this.productsSearchButton.Click += new System.EventHandler(this.ProductsSearchButton_Click);
            // 
            // partsTitle
            // 
            this.partsTitle.AutoSize = true;
            this.partsTitle.Location = new System.Drawing.Point(37, 47);
            this.partsTitle.Name = "partsTitle";
            this.partsTitle.Size = new System.Drawing.Size(31, 13);
            this.partsTitle.TabIndex = 9;
            this.partsTitle.Text = "Parts";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(1237, 301);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // productsTitle
            // 
            this.productsTitle.AutoSize = true;
            this.productsTitle.Location = new System.Drawing.Point(705, 47);
            this.productsTitle.Name = "productsTitle";
            this.productsTitle.Size = new System.Drawing.Size(49, 13);
            this.productsTitle.TabIndex = 11;
            this.productsTitle.Text = "Products";
            // 
            // partsSearch
            // 
            this.partsSearch.Location = new System.Drawing.Point(74, 40);
            this.partsSearch.Name = "partsSearch";
            this.partsSearch.Size = new System.Drawing.Size(100, 20);
            this.partsSearch.TabIndex = 12;
            this.partsSearch.TextChanged += new System.EventHandler(this.partsSearch_TextChanged);
            // 
            // productsSearch
            // 
            this.productsSearch.Location = new System.Drawing.Point(760, 41);
            this.productsSearch.Name = "productsSearch";
            this.productsSearch.Size = new System.Drawing.Size(100, 20);
            this.productsSearch.TabIndex = 13;
            this.productsSearch.TextChanged += new System.EventHandler(this.productsSearch_TextChanged);
            // 
            // partsGrid
            // 
            this.partsGrid.AllowUserToAddRows = false;
            this.partsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partsGrid.Location = new System.Drawing.Point(31, 67);
            this.partsGrid.Name = "partsGrid";
            this.partsGrid.Size = new System.Drawing.Size(643, 148);
            this.partsGrid.TabIndex = 14;
            this.partsGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.partsGrid_CellClick);
            // 
            // productsGrid
            // 
            this.productsGrid.AllowUserToAddRows = false;
            this.productsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsGrid.Location = new System.Drawing.Point(694, 67);
            this.productsGrid.Name = "productsGrid";
            this.productsGrid.Size = new System.Drawing.Size(643, 150);
            this.productsGrid.TabIndex = 15;
            this.productsGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsGrid_CellClick);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 362);
            this.Controls.Add(this.productsGrid);
            this.Controls.Add(this.partsGrid);
            this.Controls.Add(this.productsSearch);
            this.Controls.Add(this.partsSearch);
            this.Controls.Add(this.productsTitle);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.partsTitle);
            this.Controls.Add(this.productsSearchButton);
            this.Controls.Add(this.productsDelButton);
            this.Controls.Add(this.productsModifyButton);
            this.Controls.Add(this.productsAddButton);
            this.Controls.Add(this.partsDelButton);
            this.Controls.Add(this.partsModifyButton);
            this.Controls.Add(this.partsAddButton);
            this.Controls.Add(this.partsSearchButton);
            this.Controls.Add(this.mainTitle);
            this.Name = "MainScreen";
            this.Text = "Main Screen";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.partsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainTitle;
        private System.Windows.Forms.Button partsSearchButton;
        private System.Windows.Forms.Button partsAddButton;
        private System.Windows.Forms.Button partsModifyButton;
        private System.Windows.Forms.Button partsDelButton;
        private System.Windows.Forms.Button productsAddButton;
        private System.Windows.Forms.Button productsModifyButton;
        private System.Windows.Forms.Button productsDelButton;
        private System.Windows.Forms.Button productsSearchButton;
        private System.Windows.Forms.Label partsTitle;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label productsTitle;
        private System.Windows.Forms.TextBox partsSearch;
        private System.Windows.Forms.TextBox productsSearch;
        private System.Windows.Forms.DataGridView partsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn partID;
        private System.Windows.Forms.DataGridViewTextBoxColumn partName;
        private System.Windows.Forms.DataGridViewTextBoxColumn partInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn partPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn partMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn partMax;
        private System.Windows.Forms.DataGridView productsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn productID;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn productInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn productMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn productMax;
    }
}

