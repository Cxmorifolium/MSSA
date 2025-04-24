namespace assignment3_4
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.isDecafDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.varietyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roastLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.decafDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bevNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temperatureDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temperatureStringDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coffeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isDecafDataGridViewCheckBoxColumn,
            this.varietyDataGridViewTextBoxColumn,
            this.roastLevelDataGridViewTextBoxColumn,
            this.decafDataGridViewTextBoxColumn,
            this.bevNameDataGridViewTextBoxColumn,
            this.temperatureDataGridViewCheckBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.brandDataGridViewTextBoxColumn,
            this.temperatureStringDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.coffeeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(76, 80);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1295, 654);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Coffee Table";
            // 
            // isDecafDataGridViewCheckBoxColumn
            // 
            this.isDecafDataGridViewCheckBoxColumn.DataPropertyName = "IsDecaf";
            this.isDecafDataGridViewCheckBoxColumn.HeaderText = "IsDecaf";
            this.isDecafDataGridViewCheckBoxColumn.MinimumWidth = 10;
            this.isDecafDataGridViewCheckBoxColumn.Name = "isDecafDataGridViewCheckBoxColumn";
            this.isDecafDataGridViewCheckBoxColumn.Width = 200;
            // 
            // varietyDataGridViewTextBoxColumn
            // 
            this.varietyDataGridViewTextBoxColumn.DataPropertyName = "Variety";
            this.varietyDataGridViewTextBoxColumn.HeaderText = "Variety";
            this.varietyDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.varietyDataGridViewTextBoxColumn.Name = "varietyDataGridViewTextBoxColumn";
            this.varietyDataGridViewTextBoxColumn.Width = 200;
            // 
            // roastLevelDataGridViewTextBoxColumn
            // 
            this.roastLevelDataGridViewTextBoxColumn.DataPropertyName = "RoastLevel";
            this.roastLevelDataGridViewTextBoxColumn.HeaderText = "RoastLevel";
            this.roastLevelDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.roastLevelDataGridViewTextBoxColumn.Name = "roastLevelDataGridViewTextBoxColumn";
            this.roastLevelDataGridViewTextBoxColumn.Width = 200;
            // 
            // decafDataGridViewTextBoxColumn
            // 
            this.decafDataGridViewTextBoxColumn.DataPropertyName = "Decaf";
            this.decafDataGridViewTextBoxColumn.HeaderText = "Decaf";
            this.decafDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.decafDataGridViewTextBoxColumn.Name = "decafDataGridViewTextBoxColumn";
            this.decafDataGridViewTextBoxColumn.Width = 200;
            // 
            // bevNameDataGridViewTextBoxColumn
            // 
            this.bevNameDataGridViewTextBoxColumn.DataPropertyName = "BevName";
            this.bevNameDataGridViewTextBoxColumn.HeaderText = "BevName";
            this.bevNameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.bevNameDataGridViewTextBoxColumn.Name = "bevNameDataGridViewTextBoxColumn";
            this.bevNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // temperatureDataGridViewCheckBoxColumn
            // 
            this.temperatureDataGridViewCheckBoxColumn.DataPropertyName = "Temperature";
            this.temperatureDataGridViewCheckBoxColumn.HeaderText = "Temperature";
            this.temperatureDataGridViewCheckBoxColumn.MinimumWidth = 10;
            this.temperatureDataGridViewCheckBoxColumn.Name = "temperatureDataGridViewCheckBoxColumn";
            this.temperatureDataGridViewCheckBoxColumn.Width = 200;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 200;
            // 
            // brandDataGridViewTextBoxColumn
            // 
            this.brandDataGridViewTextBoxColumn.DataPropertyName = "Brand";
            this.brandDataGridViewTextBoxColumn.HeaderText = "Brand";
            this.brandDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            this.brandDataGridViewTextBoxColumn.Width = 200;
            // 
            // temperatureStringDataGridViewTextBoxColumn
            // 
            this.temperatureStringDataGridViewTextBoxColumn.DataPropertyName = "TemperatureString";
            this.temperatureStringDataGridViewTextBoxColumn.HeaderText = "TemperatureString";
            this.temperatureStringDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.temperatureStringDataGridViewTextBoxColumn.Name = "temperatureStringDataGridViewTextBoxColumn";
            this.temperatureStringDataGridViewTextBoxColumn.ReadOnly = true;
            this.temperatureStringDataGridViewTextBoxColumn.Width = 200;
            // 
            // coffeeBindingSource
            // 
            this.coffeeBindingSource.DataSource = typeof(assignment3_4.Coffee);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1597, 813);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource coffeeBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isDecafDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varietyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roastLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn decafDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bevNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn temperatureDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn temperatureStringDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}

