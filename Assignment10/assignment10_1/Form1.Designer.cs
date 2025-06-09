namespace assignment10_1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView studentGrid;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtMajor;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblMajor;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoadJson;
        private System.Windows.Forms.Button btnLoadXml;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.GroupBox groupBoxSerialization;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.studentGrid = new System.Windows.Forms.DataGridView();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtMajor = new System.Windows.Forms.TextBox();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblMajor = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoadJson = new System.Windows.Forms.Button();
            this.btnLoadXml = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.groupBoxSerialization = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.studentGrid)).BeginInit();
            this.groupBoxInput.SuspendLayout();
            this.groupBoxSerialization.SuspendLayout();
            this.SuspendLayout();

            // studentGrid
            this.studentGrid.AllowUserToAddRows = false;
            this.studentGrid.AllowUserToDeleteRows = true;
            this.studentGrid.AutoGenerateColumns = true;
            this.studentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentGrid.Location = new System.Drawing.Point(12, 12);
            this.studentGrid.MultiSelect = false;
            this.studentGrid.Name = "studentGrid";
            this.studentGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.studentGrid.Size = new System.Drawing.Size(760, 200);
            this.studentGrid.TabIndex = 0;

            // groupBoxInput
            this.groupBoxInput.Controls.Add(this.lblName);
            this.groupBoxInput.Controls.Add(this.txtName);
            this.groupBoxInput.Controls.Add(this.lblAge);
            this.groupBoxInput.Controls.Add(this.txtAge);
            this.groupBoxInput.Controls.Add(this.lblMajor);
            this.groupBoxInput.Controls.Add(this.txtMajor);
            this.groupBoxInput.Controls.Add(this.lblStudentID);
            this.groupBoxInput.Controls.Add(this.txtStudentID);
            this.groupBoxInput.Controls.Add(this.btnAdd);
            this.groupBoxInput.Location = new System.Drawing.Point(12, 230);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(350, 220);
            this.groupBoxInput.TabIndex = 1;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Add Student";

            // lblName
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(15, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";

            // txtName
            this.txtName.Location = new System.Drawing.Point(70, 27);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(250, 20);
            this.txtName.TabIndex = 1;

            // lblAge
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(15, 65);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(29, 13);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "Age:";

            // txtAge
            this.txtAge.Location = new System.Drawing.Point(70, 62);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 20);
            this.txtAge.TabIndex = 3;

            // lblMajor
            this.lblMajor.AutoSize = true;
            this.lblMajor.Location = new System.Drawing.Point(15, 100);
            this.lblMajor.Name = "lblMajor";
            this.lblMajor.Size = new System.Drawing.Size(36, 13);
            this.lblMajor.TabIndex = 4;
            this.lblMajor.Text = "Major:";

            // txtMajor
            this.txtMajor.Location = new System.Drawing.Point(70, 97);
            this.txtMajor.Name = "txtMajor";
            this.txtMajor.Size = new System.Drawing.Size(250, 20);
            this.txtMajor.TabIndex = 5;

            // lblStudentID
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Location = new System.Drawing.Point(15, 135);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(63, 13);
            this.lblStudentID.TabIndex = 6;
            this.lblStudentID.Text = "Student ID:";

            // txtStudentID
            this.txtStudentID.Location = new System.Drawing.Point(85, 132);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(100, 20);
            this.txtStudentID.TabIndex = 7;

            // btnAdd
            this.btnAdd.Location = new System.Drawing.Point(70, 170);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 30);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add Student";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // groupBoxSerialization
            this.groupBoxSerialization.Controls.Add(this.btnSave);
            this.groupBoxSerialization.Controls.Add(this.btnLoadJson);
            this.groupBoxSerialization.Controls.Add(this.btnLoadXml);
            this.groupBoxSerialization.Controls.Add(this.btnClear);
            this.groupBoxSerialization.Location = new System.Drawing.Point(380, 230);
            this.groupBoxSerialization.Name = "groupBoxSerialization";
            this.groupBoxSerialization.Size = new System.Drawing.Size(392, 120);
            this.groupBoxSerialization.TabIndex = 2;
            this.groupBoxSerialization.TabStop = false;
            this.groupBoxSerialization.Text = "File Operations";

            // btnSave
            this.btnSave.Location = new System.Drawing.Point(15, 30);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 30);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save (JSON & XML)";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // btnLoadJson
            this.btnLoadJson.Location = new System.Drawing.Point(150, 30);
            this.btnLoadJson.Name = "btnLoadJson";
            this.btnLoadJson.Size = new System.Drawing.Size(100, 30);
            this.btnLoadJson.TabIndex = 1;
            this.btnLoadJson.Text = "Load JSON";
            this.btnLoadJson.UseVisualStyleBackColor = true;
            this.btnLoadJson.Click += new System.EventHandler(this.btnLoadJson_Click);

            // btnLoadXml
            this.btnLoadXml.Location = new System.Drawing.Point(260, 30);
            this.btnLoadXml.Name = "btnLoadXml";
            this.btnLoadXml.Size = new System.Drawing.Size(100, 30);
            this.btnLoadXml.TabIndex = 2;
            this.btnLoadXml.Text = "Load XML";
            this.btnLoadXml.UseVisualStyleBackColor = true;
            this.btnLoadXml.Click += new System.EventHandler(this.btnLoadXml_Click);

            // btnClear
            this.btnClear.Location = new System.Drawing.Point(150, 75);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 30);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 470);
            this.Controls.Add(this.groupBoxSerialization);
            this.Controls.Add(this.groupBoxInput);
            this.Controls.Add(this.studentGrid);
            this.Name = "Form1";
            this.Text = "Student Serialization Demo - JSON & XML";
            ((System.ComponentModel.ISupportInitialize)(this.studentGrid)).EndInit();
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            this.groupBoxSerialization.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}