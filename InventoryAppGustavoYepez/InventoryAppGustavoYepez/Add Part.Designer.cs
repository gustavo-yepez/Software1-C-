namespace InventoryAppGustavoYepez
{
    partial class Add_Part
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
            this.inhouseRadioButton = new System.Windows.Forms.RadioButton();
            this.outsourcedRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.savePartButton = new System.Windows.Forms.Button();
            this.cancelPartCreationButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.partIDTextBox = new System.Windows.Forms.TextBox();
            this.partNameTextBox = new System.Windows.Forms.TextBox();
            this.partInventoryTextBox = new System.Windows.Forms.TextBox();
            this.partCostTextBox = new System.Windows.Forms.TextBox();
            this.partMaxTextBox = new System.Windows.Forms.TextBox();
            this.partMinTextBox = new System.Windows.Forms.TextBox();
            this.partMacComTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // inhouseRadioButton
            // 
            this.inhouseRadioButton.AutoSize = true;
            this.inhouseRadioButton.Location = new System.Drawing.Point(106, 44);
            this.inhouseRadioButton.Name = "inhouseRadioButton";
            this.inhouseRadioButton.Size = new System.Drawing.Size(68, 17);
            this.inhouseRadioButton.TabIndex = 0;
            this.inhouseRadioButton.TabStop = true;
            this.inhouseRadioButton.Text = "In-House";
            this.inhouseRadioButton.UseVisualStyleBackColor = true;
            this.inhouseRadioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // outsourcedRadioButton
            // 
            this.outsourcedRadioButton.AutoSize = true;
            this.outsourcedRadioButton.Location = new System.Drawing.Point(220, 44);
            this.outsourcedRadioButton.Name = "outsourcedRadioButton";
            this.outsourcedRadioButton.Size = new System.Drawing.Size(74, 17);
            this.outsourcedRadioButton.TabIndex = 1;
            this.outsourcedRadioButton.TabStop = true;
            this.outsourcedRadioButton.Text = "Outsource";
            this.outsourcedRadioButton.UseVisualStyleBackColor = true;
            this.outsourcedRadioButton.CheckedChanged += new System.EventHandler(this.outsourcedRadioButton_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add Part";
            // 
            // savePartButton
            // 
            this.savePartButton.Location = new System.Drawing.Point(219, 364);
            this.savePartButton.Name = "savePartButton";
            this.savePartButton.Size = new System.Drawing.Size(75, 23);
            this.savePartButton.TabIndex = 3;
            this.savePartButton.Text = "Save";
            this.savePartButton.UseVisualStyleBackColor = true;
            this.savePartButton.Click += new System.EventHandler(this.savePartButton_Click);
            // 
            // cancelPartCreationButton
            // 
            this.cancelPartCreationButton.Location = new System.Drawing.Point(311, 364);
            this.cancelPartCreationButton.Name = "cancelPartCreationButton";
            this.cancelPartCreationButton.Size = new System.Drawing.Size(75, 23);
            this.cancelPartCreationButton.TabIndex = 4;
            this.cancelPartCreationButton.Text = "Cancel";
            this.cancelPartCreationButton.UseVisualStyleBackColor = true;
            this.cancelPartCreationButton.Click += new System.EventHandler(this.cancelPartCreationButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Inventory";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Price/ Cost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Max";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(248, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Min";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(53, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Machine ID";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // partIDTextBox
            // 
            this.partIDTextBox.Location = new System.Drawing.Point(121, 82);
            this.partIDTextBox.Name = "partIDTextBox";
            this.partIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.partIDTextBox.TabIndex = 12;
            this.partIDTextBox.TextChanged += new System.EventHandler(this.partIDTextBox_TextChanged);
            // 
            // partNameTextBox
            // 
            this.partNameTextBox.Location = new System.Drawing.Point(121, 117);
            this.partNameTextBox.Name = "partNameTextBox";
            this.partNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.partNameTextBox.TabIndex = 13;
            this.partNameTextBox.TextChanged += new System.EventHandler(this.partNameTextBox_TextChanged);
            // 
            // partInventoryTextBox
            // 
            this.partInventoryTextBox.Location = new System.Drawing.Point(121, 153);
            this.partInventoryTextBox.Name = "partInventoryTextBox";
            this.partInventoryTextBox.Size = new System.Drawing.Size(100, 20);
            this.partInventoryTextBox.TabIndex = 14;
            this.partInventoryTextBox.TextChanged += new System.EventHandler(this.partInventoryTextBox_TextChanged);
            // 
            // partCostTextBox
            // 
            this.partCostTextBox.Location = new System.Drawing.Point(121, 202);
            this.partCostTextBox.Name = "partCostTextBox";
            this.partCostTextBox.Size = new System.Drawing.Size(100, 20);
            this.partCostTextBox.TabIndex = 15;
            this.partCostTextBox.TextChanged += new System.EventHandler(this.partCostTextBox_TextChanged);
            // 
            // partMaxTextBox
            // 
            this.partMaxTextBox.Location = new System.Drawing.Point(121, 246);
            this.partMaxTextBox.Name = "partMaxTextBox";
            this.partMaxTextBox.Size = new System.Drawing.Size(100, 20);
            this.partMaxTextBox.TabIndex = 16;
            this.partMaxTextBox.TextChanged += new System.EventHandler(this.partMaxTextBox_TextChanged);
            // 
            // partMinTextBox
            // 
            this.partMinTextBox.Location = new System.Drawing.Point(278, 246);
            this.partMinTextBox.Name = "partMinTextBox";
            this.partMinTextBox.Size = new System.Drawing.Size(100, 20);
            this.partMinTextBox.TabIndex = 17;
            this.partMinTextBox.TextChanged += new System.EventHandler(this.partMinTextBox_TextChanged);
            // 
            // partMacComTextBox
            // 
            this.partMacComTextBox.Location = new System.Drawing.Point(121, 284);
            this.partMacComTextBox.Name = "partMacComTextBox";
            this.partMacComTextBox.Size = new System.Drawing.Size(100, 20);
            this.partMacComTextBox.TabIndex = 18;
            this.partMacComTextBox.TextChanged += new System.EventHandler(this.partMacComTextBox_TextChanged);
            // 
            // Add_Part
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 419);
            this.Controls.Add(this.partMacComTextBox);
            this.Controls.Add(this.partMinTextBox);
            this.Controls.Add(this.partMaxTextBox);
            this.Controls.Add(this.partCostTextBox);
            this.Controls.Add(this.partInventoryTextBox);
            this.Controls.Add(this.partNameTextBox);
            this.Controls.Add(this.partIDTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancelPartCreationButton);
            this.Controls.Add(this.savePartButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outsourcedRadioButton);
            this.Controls.Add(this.inhouseRadioButton);
            this.Name = "Add_Part";
            this.Text = "Add_Part";
            this.Load += new System.EventHandler(this.Add_Part_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton inhouseRadioButton;
        private System.Windows.Forms.RadioButton outsourcedRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button savePartButton;
        private System.Windows.Forms.Button cancelPartCreationButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox partIDTextBox;
        private System.Windows.Forms.TextBox partNameTextBox;
        private System.Windows.Forms.TextBox partInventoryTextBox;
        private System.Windows.Forms.TextBox partCostTextBox;
        private System.Windows.Forms.TextBox partMaxTextBox;
        private System.Windows.Forms.TextBox partMinTextBox;
        private System.Windows.Forms.TextBox partMacComTextBox;
    }
}