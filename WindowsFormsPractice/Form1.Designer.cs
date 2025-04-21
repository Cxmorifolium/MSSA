namespace WindowsFormsPractice
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
            this.btnAdd_Click = new System.Windows.Forms.Button();
            this.lstNames = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAdd_Click
            // 
            this.btnAdd_Click.Location = new System.Drawing.Point(466, 159);
            this.btnAdd_Click.Name = "btnAdd_Click";
            this.btnAdd_Click.Size = new System.Drawing.Size(203, 44);
            this.btnAdd_Click.TabIndex = 0;
            this.btnAdd_Click.Text = "Add Name";
            this.btnAdd_Click.UseVisualStyleBackColor = true;
            this.btnAdd_Click.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstNames
            // 
            this.lstNames.FormattingEnabled = true;
            this.lstNames.ItemHeight = 25;
            this.lstNames.Location = new System.Drawing.Point(39, 108);
            this.lstNames.Name = "lstNames";
            this.lstNames.Size = new System.Drawing.Size(382, 304);
            this.lstNames.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Names";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(466, 108);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(203, 31);
            this.txtName.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstNames);
            this.Controls.Add(this.btnAdd_Click);
            this.Name = "Form1";
            this.Text = "Name";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd_Click;
        private System.Windows.Forms.ListBox lstNames;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
    }
}

