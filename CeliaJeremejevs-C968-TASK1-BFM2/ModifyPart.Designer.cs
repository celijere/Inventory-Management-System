namespace IMS
{
    partial class ModifyPart
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
            this.modifyPartOuts = new System.Windows.Forms.RadioButton();
            this.modifyPartInH = new System.Windows.Forms.RadioButton();
            this.cancelModifyPart = new System.Windows.Forms.Button();
            this.saveModifyPart = new System.Windows.Forms.Button();
            this.modifyPartMIDTextBox = new System.Windows.Forms.TextBox();
            this.modifyPartMinTextBox = new System.Windows.Forms.TextBox();
            this.modifyPartMaxTextBox = new System.Windows.Forms.TextBox();
            this.modifyPartPCTextBox = new System.Windows.Forms.TextBox();
            this.modifyPartInventoryTextBox = new System.Windows.Forms.TextBox();
            this.modifyPartNameTextBox = new System.Windows.Forms.TextBox();
            this.modifyPartIDTextBox = new System.Windows.Forms.TextBox();
            this.modifyPartMIDLabel = new System.Windows.Forms.Label();
            this.modifyPartMinLabel = new System.Windows.Forms.Label();
            this.modifyPartMaxLabel = new System.Windows.Forms.Label();
            this.modifyPartPCLabel = new System.Windows.Forms.Label();
            this.modifyPartInventoryLabel = new System.Windows.Forms.Label();
            this.modifyPartNameLabel = new System.Windows.Forms.Label();
            this.modifyPartID = new System.Windows.Forms.Label();
            this.modifyPartTitle = new System.Windows.Forms.Label();
            this.modifyPartOSTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // modifyPartOuts
            // 
            this.modifyPartOuts.AutoSize = true;
            this.modifyPartOuts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyPartOuts.Location = new System.Drawing.Point(220, 10);
            this.modifyPartOuts.Name = "modifyPartOuts";
            this.modifyPartOuts.Size = new System.Drawing.Size(94, 20);
            this.modifyPartOuts.TabIndex = 37;
            this.modifyPartOuts.Text = "Outsourced";
            this.modifyPartOuts.UseVisualStyleBackColor = true;
            this.modifyPartOuts.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // modifyPartInH
            // 
            this.modifyPartInH.AutoSize = true;
            this.modifyPartInH.Checked = true;
            this.modifyPartInH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyPartInH.Location = new System.Drawing.Point(129, 10);
            this.modifyPartInH.Name = "modifyPartInH";
            this.modifyPartInH.Size = new System.Drawing.Size(79, 20);
            this.modifyPartInH.TabIndex = 36;
            this.modifyPartInH.TabStop = true;
            this.modifyPartInH.Text = "In-House";
            this.modifyPartInH.UseVisualStyleBackColor = true;
            this.modifyPartInH.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // cancelModifyPart
            // 
            this.cancelModifyPart.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cancelModifyPart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelModifyPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelModifyPart.Location = new System.Drawing.Point(335, 306);
            this.cancelModifyPart.Name = "cancelModifyPart";
            this.cancelModifyPart.Size = new System.Drawing.Size(90, 30);
            this.cancelModifyPart.TabIndex = 35;
            this.cancelModifyPart.Text = "Cancel";
            this.cancelModifyPart.UseVisualStyleBackColor = false;
            this.cancelModifyPart.Click += new System.EventHandler(this.cancelModifyPart_Click);
            // 
            // saveModifyPart
            // 
            this.saveModifyPart.BackColor = System.Drawing.SystemColors.ControlLight;
            this.saveModifyPart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveModifyPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveModifyPart.Location = new System.Drawing.Point(224, 306);
            this.saveModifyPart.Name = "saveModifyPart";
            this.saveModifyPart.Size = new System.Drawing.Size(90, 30);
            this.saveModifyPart.TabIndex = 34;
            this.saveModifyPart.Text = "Save";
            this.saveModifyPart.UseVisualStyleBackColor = false;
            this.saveModifyPart.Click += new System.EventHandler(this.saveModifyPart_Click);
            // 
            // modifyPartMIDTextBox
            // 
            this.modifyPartMIDTextBox.Location = new System.Drawing.Point(156, 251);
            this.modifyPartMIDTextBox.Name = "modifyPartMIDTextBox";
            this.modifyPartMIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.modifyPartMIDTextBox.TabIndex = 33;
            this.modifyPartMIDTextBox.Visible = false;
            // 
            // modifyPartMinTextBox
            // 
            this.modifyPartMinTextBox.Location = new System.Drawing.Point(287, 211);
            this.modifyPartMinTextBox.Name = "modifyPartMinTextBox";
            this.modifyPartMinTextBox.Size = new System.Drawing.Size(70, 20);
            this.modifyPartMinTextBox.TabIndex = 32;
            // 
            // modifyPartMaxTextBox
            // 
            this.modifyPartMaxTextBox.Location = new System.Drawing.Point(156, 211);
            this.modifyPartMaxTextBox.Name = "modifyPartMaxTextBox";
            this.modifyPartMaxTextBox.Size = new System.Drawing.Size(70, 20);
            this.modifyPartMaxTextBox.TabIndex = 31;
            // 
            // modifyPartPCTextBox
            // 
            this.modifyPartPCTextBox.Location = new System.Drawing.Point(156, 172);
            this.modifyPartPCTextBox.Name = "modifyPartPCTextBox";
            this.modifyPartPCTextBox.Size = new System.Drawing.Size(100, 20);
            this.modifyPartPCTextBox.TabIndex = 30;
            // 
            // modifyPartInventoryTextBox
            // 
            this.modifyPartInventoryTextBox.Location = new System.Drawing.Point(156, 132);
            this.modifyPartInventoryTextBox.Name = "modifyPartInventoryTextBox";
            this.modifyPartInventoryTextBox.Size = new System.Drawing.Size(100, 20);
            this.modifyPartInventoryTextBox.TabIndex = 29;
            // 
            // modifyPartNameTextBox
            // 
            this.modifyPartNameTextBox.Location = new System.Drawing.Point(156, 93);
            this.modifyPartNameTextBox.Name = "modifyPartNameTextBox";
            this.modifyPartNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.modifyPartNameTextBox.TabIndex = 28;
            // 
            // modifyPartIDTextBox
            // 
            this.modifyPartIDTextBox.Enabled = false;
            this.modifyPartIDTextBox.Location = new System.Drawing.Point(156, 58);
            this.modifyPartIDTextBox.Name = "modifyPartIDTextBox";
            this.modifyPartIDTextBox.ReadOnly = true;
            this.modifyPartIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.modifyPartIDTextBox.TabIndex = 27;
            // 
            // modifyPartMIDLabel
            // 
            this.modifyPartMIDLabel.AutoSize = true;
            this.modifyPartMIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyPartMIDLabel.Location = new System.Drawing.Point(43, 255);
            this.modifyPartMIDLabel.Name = "modifyPartMIDLabel";
            this.modifyPartMIDLabel.Size = new System.Drawing.Size(0, 16);
            this.modifyPartMIDLabel.TabIndex = 26;
            // 
            // modifyPartMinLabel
            // 
            this.modifyPartMinLabel.AutoSize = true;
            this.modifyPartMinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyPartMinLabel.Location = new System.Drawing.Point(243, 211);
            this.modifyPartMinLabel.Name = "modifyPartMinLabel";
            this.modifyPartMinLabel.Size = new System.Drawing.Size(28, 16);
            this.modifyPartMinLabel.TabIndex = 25;
            this.modifyPartMinLabel.Text = "Min";
            // 
            // modifyPartMaxLabel
            // 
            this.modifyPartMaxLabel.AutoSize = true;
            this.modifyPartMaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyPartMaxLabel.Location = new System.Drawing.Point(112, 211);
            this.modifyPartMaxLabel.Name = "modifyPartMaxLabel";
            this.modifyPartMaxLabel.Size = new System.Drawing.Size(32, 16);
            this.modifyPartMaxLabel.TabIndex = 24;
            this.modifyPartMaxLabel.Text = "Max";
            // 
            // modifyPartPCLabel
            // 
            this.modifyPartPCLabel.AutoSize = true;
            this.modifyPartPCLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyPartPCLabel.Location = new System.Drawing.Point(70, 172);
            this.modifyPartPCLabel.Name = "modifyPartPCLabel";
            this.modifyPartPCLabel.Size = new System.Drawing.Size(75, 16);
            this.modifyPartPCLabel.TabIndex = 23;
            this.modifyPartPCLabel.Text = "Price / Cost";
            // 
            // modifyPartInventoryLabel
            // 
            this.modifyPartInventoryLabel.AutoSize = true;
            this.modifyPartInventoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyPartInventoryLabel.Location = new System.Drawing.Point(83, 132);
            this.modifyPartInventoryLabel.Name = "modifyPartInventoryLabel";
            this.modifyPartInventoryLabel.Size = new System.Drawing.Size(61, 16);
            this.modifyPartInventoryLabel.TabIndex = 22;
            this.modifyPartInventoryLabel.Text = "Inventory";
            // 
            // modifyPartNameLabel
            // 
            this.modifyPartNameLabel.AutoSize = true;
            this.modifyPartNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyPartNameLabel.Location = new System.Drawing.Point(100, 97);
            this.modifyPartNameLabel.Name = "modifyPartNameLabel";
            this.modifyPartNameLabel.Size = new System.Drawing.Size(44, 16);
            this.modifyPartNameLabel.TabIndex = 21;
            this.modifyPartNameLabel.Text = "Name";
            // 
            // modifyPartID
            // 
            this.modifyPartID.AutoSize = true;
            this.modifyPartID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyPartID.Location = new System.Drawing.Point(124, 62);
            this.modifyPartID.Name = "modifyPartID";
            this.modifyPartID.Size = new System.Drawing.Size(20, 16);
            this.modifyPartID.TabIndex = 20;
            this.modifyPartID.Text = "ID";
            // 
            // modifyPartTitle
            // 
            this.modifyPartTitle.AutoSize = true;
            this.modifyPartTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyPartTitle.Location = new System.Drawing.Point(11, 9);
            this.modifyPartTitle.Name = "modifyPartTitle";
            this.modifyPartTitle.Size = new System.Drawing.Size(88, 20);
            this.modifyPartTitle.TabIndex = 19;
            this.modifyPartTitle.Text = "Modify Part";
            // 
            // modifyPartOSTextBox
            // 
            this.modifyPartOSTextBox.Location = new System.Drawing.Point(156, 251);
            this.modifyPartOSTextBox.Name = "modifyPartOSTextBox";
            this.modifyPartOSTextBox.Size = new System.Drawing.Size(100, 20);
            this.modifyPartOSTextBox.TabIndex = 38;
            this.modifyPartOSTextBox.Visible = false;
            // 
            // ModifyPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 382);
            this.Controls.Add(this.modifyPartOSTextBox);
            this.Controls.Add(this.modifyPartOuts);
            this.Controls.Add(this.modifyPartInH);
            this.Controls.Add(this.cancelModifyPart);
            this.Controls.Add(this.saveModifyPart);
            this.Controls.Add(this.modifyPartMIDTextBox);
            this.Controls.Add(this.modifyPartMinTextBox);
            this.Controls.Add(this.modifyPartMaxTextBox);
            this.Controls.Add(this.modifyPartPCTextBox);
            this.Controls.Add(this.modifyPartInventoryTextBox);
            this.Controls.Add(this.modifyPartNameTextBox);
            this.Controls.Add(this.modifyPartIDTextBox);
            this.Controls.Add(this.modifyPartMIDLabel);
            this.Controls.Add(this.modifyPartMinLabel);
            this.Controls.Add(this.modifyPartMaxLabel);
            this.Controls.Add(this.modifyPartPCLabel);
            this.Controls.Add(this.modifyPartInventoryLabel);
            this.Controls.Add(this.modifyPartNameLabel);
            this.Controls.Add(this.modifyPartID);
            this.Controls.Add(this.modifyPartTitle);
            this.Name = "ModifyPart";
            this.Text = "ModifyPart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton modifyPartOuts;
        private System.Windows.Forms.RadioButton modifyPartInH;
        private System.Windows.Forms.Button cancelModifyPart;
        private System.Windows.Forms.Button saveModifyPart;
        private System.Windows.Forms.TextBox modifyPartMIDTextBox;
        private System.Windows.Forms.TextBox modifyPartMinTextBox;
        private System.Windows.Forms.TextBox modifyPartMaxTextBox;
        private System.Windows.Forms.TextBox modifyPartPCTextBox;
        private System.Windows.Forms.TextBox modifyPartInventoryTextBox;
        private System.Windows.Forms.TextBox modifyPartNameTextBox;
        private System.Windows.Forms.TextBox modifyPartIDTextBox;
        private System.Windows.Forms.Label modifyPartMIDLabel;
        private System.Windows.Forms.Label modifyPartMinLabel;
        private System.Windows.Forms.Label modifyPartMaxLabel;
        private System.Windows.Forms.Label modifyPartPCLabel;
        private System.Windows.Forms.Label modifyPartInventoryLabel;
        private System.Windows.Forms.Label modifyPartNameLabel;
        private System.Windows.Forms.Label modifyPartID;
        private System.Windows.Forms.Label modifyPartTitle;
        private System.Windows.Forms.TextBox modifyPartOSTextBox;
    }
}