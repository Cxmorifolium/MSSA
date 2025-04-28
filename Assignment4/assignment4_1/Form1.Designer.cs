namespace assignment4_1
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
            this.addressGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.firstname = new System.Windows.Forms.Label();
            this.lastname = new System.Windows.Forms.Label();
            this.mobilephone = new System.Windows.Forms.Label();
            this.workphone = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtMobilePhone = new System.Windows.Forms.TextBox();
            this.txtWorkPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.inputbox = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.addressGrid)).BeginInit();
            this.inputbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // addressGrid
            // 
            this.addressGrid.AllowUserToOrderColumns = true;
            this.addressGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addressGrid.Location = new System.Drawing.Point(41, 153);
            this.addressGrid.Name = "addressGrid";
            this.addressGrid.RowHeadersWidth = 82;
            this.addressGrid.RowTemplate.Height = 33;
            this.addressGrid.Size = new System.Drawing.Size(1136, 571);
            this.addressGrid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Address Book";
            // 
            // firstname
            // 
            this.firstname.AutoSize = true;
            this.firstname.Location = new System.Drawing.Point(11, 48);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(116, 25);
            this.firstname.TabIndex = 2;
            this.firstname.Text = "First Name";
            // 
            // lastname
            // 
            this.lastname.AutoSize = true;
            this.lastname.Location = new System.Drawing.Point(11, 87);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(115, 25);
            this.lastname.TabIndex = 3;
            this.lastname.Text = "Last Name";
            // 
            // mobilephone
            // 
            this.mobilephone.AutoSize = true;
            this.mobilephone.Location = new System.Drawing.Point(11, 125);
            this.mobilephone.Name = "mobilephone";
            this.mobilephone.Size = new System.Drawing.Size(162, 25);
            this.mobilephone.TabIndex = 4;
            this.mobilephone.Text = "Mobile Phone #";
            // 
            // workphone
            // 
            this.workphone.AutoSize = true;
            this.workphone.Location = new System.Drawing.Point(11, 163);
            this.workphone.Name = "workphone";
            this.workphone.Size = new System.Drawing.Size(148, 25);
            this.workphone.TabIndex = 5;
            this.workphone.Text = "Work Phone #";
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Location = new System.Drawing.Point(11, 200);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(91, 25);
            this.address.TabIndex = 6;
            this.address.Text = "Address";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(176, 42);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(218, 31);
            this.txtFirstName.TabIndex = 7;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(176, 81);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(218, 31);
            this.txtLastName.TabIndex = 8;
            // 
            // txtMobilePhone
            // 
            this.txtMobilePhone.Location = new System.Drawing.Point(176, 119);
            this.txtMobilePhone.Name = "txtMobilePhone";
            this.txtMobilePhone.Size = new System.Drawing.Size(218, 31);
            this.txtMobilePhone.TabIndex = 9;
            // 
            // txtWorkPhone
            // 
            this.txtWorkPhone.Location = new System.Drawing.Point(176, 157);
            this.txtWorkPhone.Name = "txtWorkPhone";
            this.txtWorkPhone.Size = new System.Drawing.Size(218, 31);
            this.txtWorkPhone.TabIndex = 10;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(176, 194);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(218, 31);
            this.txtAddress.TabIndex = 11;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(270, 246);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(124, 39);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(270, 301);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(124, 38);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // inputbox
            // 
            this.inputbox.Controls.Add(this.btn_Reset);
            this.inputbox.Controls.Add(this.txtSearch);
            this.inputbox.Controls.Add(this.Search);
            this.inputbox.Controls.Add(this.btn_Search);
            this.inputbox.Controls.Add(this.firstname);
            this.inputbox.Controls.Add(this.btnSave);
            this.inputbox.Controls.Add(this.lastname);
            this.inputbox.Controls.Add(this.btnAdd);
            this.inputbox.Controls.Add(this.mobilephone);
            this.inputbox.Controls.Add(this.txtAddress);
            this.inputbox.Controls.Add(this.workphone);
            this.inputbox.Controls.Add(this.txtWorkPhone);
            this.inputbox.Controls.Add(this.address);
            this.inputbox.Controls.Add(this.txtMobilePhone);
            this.inputbox.Controls.Add(this.txtFirstName);
            this.inputbox.Controls.Add(this.txtLastName);
            this.inputbox.Location = new System.Drawing.Point(1183, 153);
            this.inputbox.Name = "inputbox";
            this.inputbox.Size = new System.Drawing.Size(409, 571);
            this.inputbox.TabIndex = 14;
            this.inputbox.TabStop = false;
            this.inputbox.Text = "Input";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 400);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(382, 31);
            this.txtSearch.TabIndex = 16;
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Location = new System.Drawing.Point(7, 371);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(80, 25);
            this.Search.TabIndex = 15;
            this.Search.Text = "Search";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(270, 437);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(124, 39);
            this.btn_Search.TabIndex = 14;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(270, 483);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(124, 37);
            this.btn_Reset.TabIndex = 17;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1604, 859);
            this.Controls.Add(this.inputbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addressGrid);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.addressGrid)).EndInit();
            this.inputbox.ResumeLayout(false);
            this.inputbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView addressGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label firstname;
        private System.Windows.Forms.Label lastname;
        private System.Windows.Forms.Label mobilephone;
        private System.Windows.Forms.Label workphone;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtMobilePhone;
        private System.Windows.Forms.TextBox txtWorkPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox inputbox;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.Button btn_Reset;
    }
}

