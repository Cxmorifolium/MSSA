namespace crudapp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            empGrid = new DataGridView();
            lblEmployeeId = new Label();
            lblEmployeeName = new Label();
            lblEmployeeSalary = new Label();
            lblEmployeeDepartment = new Label();
            txtId = new TextBox();
            txtName = new TextBox();
            txtSalary = new TextBox();
            btnAddNew = new Button();
            btnSelect = new Button();
            btnRefresh = new Button();
            btnDelete = new Button();
            btnSubmit = new Button();
            btnUpdate = new Button();
            cbxDepartment = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)empGrid).BeginInit();
            SuspendLayout();
            // 
            // empGrid
            // 
            empGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            empGrid.Location = new Point(47, 42);
            empGrid.Name = "empGrid";
            empGrid.RowHeadersWidth = 82;
            empGrid.Size = new Size(1001, 222);
            empGrid.TabIndex = 0;
            // 
            // lblEmployeeId
            // 
            lblEmployeeId.AutoSize = true;
            lblEmployeeId.Location = new Point(47, 309);
            lblEmployeeId.Name = "lblEmployeeId";
            lblEmployeeId.Size = new Size(149, 32);
            lblEmployeeId.TabIndex = 1;
            lblEmployeeId.Text = "Employee ID";
            // 
            // lblEmployeeName
            // 
            lblEmployeeName.AutoSize = true;
            lblEmployeeName.Location = new Point(47, 355);
            lblEmployeeName.Name = "lblEmployeeName";
            lblEmployeeName.Size = new Size(190, 32);
            lblEmployeeName.TabIndex = 2;
            lblEmployeeName.Text = "Employee Name";
            // 
            // lblEmployeeSalary
            // 
            lblEmployeeSalary.AutoSize = true;
            lblEmployeeSalary.Location = new Point(46, 400);
            lblEmployeeSalary.Name = "lblEmployeeSalary";
            lblEmployeeSalary.Size = new Size(189, 32);
            lblEmployeeSalary.TabIndex = 3;
            lblEmployeeSalary.Text = "Employee Salary";
            // 
            // lblEmployeeDepartment
            // 
            lblEmployeeDepartment.AutoSize = true;
            lblEmployeeDepartment.Location = new Point(46, 445);
            lblEmployeeDepartment.Name = "lblEmployeeDepartment";
            lblEmployeeDepartment.Size = new Size(254, 32);
            lblEmployeeDepartment.TabIndex = 4;
            lblEmployeeDepartment.Text = "Employee Department";
            // 
            // txtId
            // 
            txtId.Location = new Point(372, 302);
            txtId.Name = "txtId";
            txtId.Size = new Size(351, 39);
            txtId.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Location = new Point(372, 348);
            txtName.Name = "txtName";
            txtName.Size = new Size(350, 39);
            txtName.TabIndex = 6;
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(372, 393);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(351, 39);
            txtSalary.TabIndex = 7;
            // 
            // btnAddNew
            // 
            btnAddNew.Location = new Point(56, 501);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(150, 46);
            btnAddNew.TabIndex = 9;
            btnAddNew.Text = "Add New";
            btnAddNew.UseVisualStyleBackColor = true;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(212, 501);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(212, 46);
            btnSelect.TabIndex = 10;
            btnSelect.Text = "Select to Update";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(430, 501);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(150, 46);
            btnRefresh.TabIndex = 11;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(898, 501);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 46);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(586, 501);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(150, 46);
            btnSubmit.TabIndex = 13;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(742, 501);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(150, 46);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // cbxDepartment
            // 
            cbxDepartment.FormattingEnabled = true;
            cbxDepartment.Location = new Point(372, 438);
            cbxDepartment.Name = "cbxDepartment";
            cbxDepartment.Size = new Size(351, 40);
            cbxDepartment.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1105, 579);
            Controls.Add(cbxDepartment);
            Controls.Add(btnUpdate);
            Controls.Add(btnSubmit);
            Controls.Add(btnDelete);
            Controls.Add(btnRefresh);
            Controls.Add(btnSelect);
            Controls.Add(btnAddNew);
            Controls.Add(txtSalary);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(lblEmployeeDepartment);
            Controls.Add(lblEmployeeSalary);
            Controls.Add(lblEmployeeName);
            Controls.Add(lblEmployeeId);
            Controls.Add(empGrid);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)empGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView empGrid;
        private Label lblEmployeeId;
        private Label lblEmployeeName;
        private Label lblEmployeeSalary;
        private Label lblEmployeeDepartment;
        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtSalary;
        private Button btnAddNew;
        private Button btnSelect;
        private Button btnRefresh;
        private Button btnDelete;
        private Button btnSubmit;
        private Button btnUpdate;
        private ComboBox cbxDepartment;
    }
}
