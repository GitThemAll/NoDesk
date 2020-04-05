namespace NoDesk.View
{
    partial class AddUser
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
            this.lblemail = new System.Windows.Forms.Label();
            this.lblfirstname = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.lbllastname = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.lbladmin = new System.Windows.Forms.Label();
            this.rbAdmin = new System.Windows.Forms.RadioButton();
            this.rbEmployee = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(48, 66);
            this.lblemail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(32, 13);
            this.lblemail.TabIndex = 0;
            this.lblemail.Text = "Email";
            // 
            // lblfirstname
            // 
            this.lblfirstname.AutoSize = true;
            this.lblfirstname.Location = new System.Drawing.Point(48, 110);
            this.lblfirstname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblfirstname.Name = "lblfirstname";
            this.lblfirstname.Size = new System.Drawing.Size(57, 13);
            this.lblfirstname.TabIndex = 1;
            this.lblfirstname.Text = "First Name";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Location = new System.Drawing.Point(48, 231);
            this.lblpassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(53, 13);
            this.lblpassword.TabIndex = 2;
            this.lblpassword.Text = "Password";
            // 
            // lbllastname
            // 
            this.lbllastname.AutoSize = true;
            this.lbllastname.Location = new System.Drawing.Point(48, 155);
            this.lbllastname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbllastname.Name = "lbllastname";
            this.lbllastname.Size = new System.Drawing.Size(58, 13);
            this.lbllastname.TabIndex = 3;
            this.lbllastname.Text = "Last Name";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(117, 62);
            this.txtemail.Margin = new System.Windows.Forms.Padding(2);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(133, 20);
            this.txtemail.TabIndex = 4;
            // 
            // txtfirstname
            // 
            this.txtfirstname.Location = new System.Drawing.Point(117, 108);
            this.txtfirstname.Margin = new System.Windows.Forms.Padding(2);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(133, 20);
            this.txtfirstname.TabIndex = 5;
            // 
            // txtlastname
            // 
            this.txtlastname.Location = new System.Drawing.Point(117, 155);
            this.txtlastname.Margin = new System.Windows.Forms.Padding(2);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(133, 20);
            this.txtlastname.TabIndex = 6;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(117, 228);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(133, 20);
            this.txtpassword.TabIndex = 7;
            // 
            // btnsubmit
            // 
            this.btnsubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnsubmit.Location = new System.Drawing.Point(80, 285);
            this.btnsubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(146, 30);
            this.btnsubmit.TabIndex = 8;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = false;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // lbladmin
            // 
            this.lbladmin.AutoSize = true;
            this.lbladmin.Location = new System.Drawing.Point(48, 194);
            this.lbladmin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbladmin.Name = "lbladmin";
            this.lbladmin.Size = new System.Drawing.Size(29, 13);
            this.lbladmin.TabIndex = 9;
            this.lbladmin.Text = "Role";
            // 
            // rbAdmin
            // 
            this.rbAdmin.AutoSize = true;
            this.rbAdmin.Location = new System.Drawing.Point(117, 194);
            this.rbAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.rbAdmin.Name = "rbAdmin";
            this.rbAdmin.Size = new System.Drawing.Size(67, 26);
            this.rbAdmin.TabIndex = 10;
            this.rbAdmin.TabStop = true;
            this.rbAdmin.Text = "Admin";
            this.rbAdmin.UseVisualStyleBackColor = true;
            this.rbAdmin.CheckedChanged += new System.EventHandler(this.rbYes_CheckedChanged);
            // 
            // rbEmployee
            // 
            this.rbEmployee.AutoSize = true;
            this.rbEmployee.Location = new System.Drawing.Point(179, 194);
            this.rbEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.rbEmployee.Name = "rbEmployee";
            this.rbEmployee.Size = new System.Drawing.Size(84, 26);
            this.rbEmployee.TabIndex = 11;
            this.rbEmployee.TabStop = true;
            this.rbEmployee.Text = "Employee";
            this.rbEmployee.UseVisualStyleBackColor = true;
            this.rbEmployee.CheckedChanged += new System.EventHandler(this.rbNo_CheckedChanged);
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 370);
            this.Controls.Add(this.rbEmployee);
            this.Controls.Add(this.rbAdmin);
            this.Controls.Add(this.lbladmin);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtlastname);
            this.Controls.Add(this.txtfirstname);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.lbllastname);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblfirstname);
            this.Controls.Add(this.lblemail);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddUser";
            this.Text = "AddUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblfirstname;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lbllastname;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.Label lbladmin;
        private System.Windows.Forms.RadioButton rbAdmin;
        private System.Windows.Forms.RadioButton rbEmployee;
    }
}