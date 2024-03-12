namespace InventoryAppGustavoYepez
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deletePartButton = new System.Windows.Forms.Button();
            this.modifyPartButton = new System.Windows.Forms.Button();
            this.addPartButton = new System.Windows.Forms.Button();
            this.partGridView = new System.Windows.Forms.DataGridView();
            this.searchPartButton = new System.Windows.Forms.Button();
            this.partSearchTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.deleteProductButton = new System.Windows.Forms.Button();
            this.modifyProductButton = new System.Windows.Forms.Button();
            this.addProductButton = new System.Windows.Forms.Button();
            this.productGridView = new System.Windows.Forms.DataGridView();
            this.productSearchTextBox = new System.Windows.Forms.TextBox();
            this.searchProductButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.exitAppButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deletePartButton);
            this.groupBox1.Controls.Add(this.modifyPartButton);
            this.groupBox1.Controls.Add(this.addPartButton);
            this.groupBox1.Controls.Add(this.partGridView);
            this.groupBox1.Controls.Add(this.searchPartButton);
            this.groupBox1.Controls.Add(this.partSearchTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(16, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 300);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // deletePartButton
            // 
            this.deletePartButton.Location = new System.Drawing.Point(352, 262);
            this.deletePartButton.Name = "deletePartButton";
            this.deletePartButton.Size = new System.Drawing.Size(75, 23);
            this.deletePartButton.TabIndex = 30;
            this.deletePartButton.Text = "Delete";
            this.deletePartButton.UseVisualStyleBackColor = true;
            this.deletePartButton.Click += new System.EventHandler(this.deletePartButton_Click);
            // 
            // modifyPartButton
            // 
            this.modifyPartButton.Location = new System.Drawing.Point(271, 262);
            this.modifyPartButton.Name = "modifyPartButton";
            this.modifyPartButton.Size = new System.Drawing.Size(75, 23);
            this.modifyPartButton.TabIndex = 29;
            this.modifyPartButton.Text = "Modify";
            this.modifyPartButton.UseVisualStyleBackColor = true;
            this.modifyPartButton.Click += new System.EventHandler(this.modifyPartButton_Click);
            // 
            // addPartButton
            // 
            this.addPartButton.Location = new System.Drawing.Point(190, 262);
            this.addPartButton.Name = "addPartButton";
            this.addPartButton.Size = new System.Drawing.Size(75, 23);
            this.addPartButton.TabIndex = 28;
            this.addPartButton.Text = "Add";
            this.addPartButton.UseVisualStyleBackColor = true;
            this.addPartButton.Click += new System.EventHandler(this.addPartButton_Click);
            // 
            // partGridView
            // 
            this.partGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.partGridView.Location = new System.Drawing.Point(22, 63);
            this.partGridView.Name = "partGridView";
            this.partGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.partGridView.Size = new System.Drawing.Size(421, 193);
            this.partGridView.TabIndex = 23;
            this.partGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // searchPartButton
            // 
            this.searchPartButton.Location = new System.Drawing.Point(190, 25);
            this.searchPartButton.Name = "searchPartButton";
            this.searchPartButton.Size = new System.Drawing.Size(75, 23);
            this.searchPartButton.TabIndex = 23;
            this.searchPartButton.Text = "Search";
            this.searchPartButton.UseVisualStyleBackColor = true;
            this.searchPartButton.Click += new System.EventHandler(this.searchPartButton_Click);
            // 
            // partSearchTextBox
            // 
            this.partSearchTextBox.Location = new System.Drawing.Point(271, 28);
            this.partSearchTextBox.Name = "partSearchTextBox";
            this.partSearchTextBox.Size = new System.Drawing.Size(172, 20);
            this.partSearchTextBox.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(18, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Parts";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.deleteProductButton);
            this.groupBox2.Controls.Add(this.modifyProductButton);
            this.groupBox2.Controls.Add(this.addProductButton);
            this.groupBox2.Controls.Add(this.productGridView);
            this.groupBox2.Controls.Add(this.productSearchTextBox);
            this.groupBox2.Controls.Add(this.searchProductButton);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(509, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 300);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // deleteProductButton
            // 
            this.deleteProductButton.Location = new System.Drawing.Point(360, 262);
            this.deleteProductButton.Name = "deleteProductButton";
            this.deleteProductButton.Size = new System.Drawing.Size(75, 23);
            this.deleteProductButton.TabIndex = 33;
            this.deleteProductButton.Text = "Delete";
            this.deleteProductButton.UseVisualStyleBackColor = true;
            this.deleteProductButton.Click += new System.EventHandler(this.deleteProductButton_Click);
            // 
            // modifyProductButton
            // 
            this.modifyProductButton.Location = new System.Drawing.Point(279, 262);
            this.modifyProductButton.Name = "modifyProductButton";
            this.modifyProductButton.Size = new System.Drawing.Size(75, 23);
            this.modifyProductButton.TabIndex = 32;
            this.modifyProductButton.Text = "Modify";
            this.modifyProductButton.UseVisualStyleBackColor = true;
            this.modifyProductButton.Click += new System.EventHandler(this.modifyProductButton_Click);
            // 
            // addProductButton
            // 
            this.addProductButton.Location = new System.Drawing.Point(198, 262);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(75, 23);
            this.addProductButton.TabIndex = 31;
            this.addProductButton.Text = "Add";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // productGridView
            // 
            this.productGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productGridView.Location = new System.Drawing.Point(27, 63);
            this.productGridView.Name = "productGridView";
            this.productGridView.Size = new System.Drawing.Size(421, 193);
            this.productGridView.TabIndex = 27;
            // 
            // productSearchTextBox
            // 
            this.productSearchTextBox.Location = new System.Drawing.Point(279, 32);
            this.productSearchTextBox.Name = "productSearchTextBox";
            this.productSearchTextBox.Size = new System.Drawing.Size(172, 20);
            this.productSearchTextBox.TabIndex = 26;
            // 
            // searchProductButton
            // 
            this.searchProductButton.Location = new System.Drawing.Point(198, 30);
            this.searchProductButton.Name = "searchProductButton";
            this.searchProductButton.Size = new System.Drawing.Size(75, 23);
            this.searchProductButton.TabIndex = 24;
            this.searchProductButton.Text = "Search";
            this.searchProductButton.UseVisualStyleBackColor = true;
            this.searchProductButton.Click += new System.EventHandler(this.searchProductButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(23, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Products";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Inventory Management System";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // exitAppButton
            // 
            this.exitAppButton.Location = new System.Drawing.Point(869, 379);
            this.exitAppButton.Name = "exitAppButton";
            this.exitAppButton.Size = new System.Drawing.Size(75, 23);
            this.exitAppButton.TabIndex = 23;
            this.exitAppButton.Text = "Exit";
            this.exitAppButton.UseVisualStyleBackColor = true;
            this.exitAppButton.Click += new System.EventHandler(this.exitAppButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 414);
            this.Controls.Add(this.exitAppButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button searchPartButton;
        private System.Windows.Forms.TextBox partSearchTextBox;
        private System.Windows.Forms.TextBox productSearchTextBox;
        private System.Windows.Forms.Button searchProductButton;
        public System.Windows.Forms.DataGridView partGridView;
        private System.Windows.Forms.DataGridView productGridView;
        private System.Windows.Forms.Button deletePartButton;
        private System.Windows.Forms.Button modifyPartButton;
        private System.Windows.Forms.Button addPartButton;
        private System.Windows.Forms.Button deleteProductButton;
        private System.Windows.Forms.Button modifyProductButton;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Button exitAppButton;
    }
}

