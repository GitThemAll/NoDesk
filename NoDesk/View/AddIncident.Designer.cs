namespace NoDesk.View
{
    partial class AddIncident
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
			this.btn_addIncident = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.inpt_incident_user = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.inpt_incident_subject = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.inpt_incident_dueDate = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.inpt_incident_assignedEmployee = new System.Windows.Forms.ComboBox();
			this.inpt_incident_summary = new System.Windows.Forms.RichTextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.btn_editIncident = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btn_addIncident
			// 
			this.btn_addIncident.BackColor = System.Drawing.Color.Silver;
			this.btn_addIncident.Location = new System.Drawing.Point(568, 309);
			this.btn_addIncident.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btn_addIncident.Name = "btn_addIncident";
			this.btn_addIncident.Size = new System.Drawing.Size(203, 65);
			this.btn_addIncident.TabIndex = 0;
			this.btn_addIncident.Text = "Add Incident";
			this.btn_addIncident.UseVisualStyleBackColor = false;
			this.btn_addIncident.Click += new System.EventHandler(this.btn_addIncident_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(10, 47);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 17);
			this.label1.TabIndex = 12;
			this.label1.Text = "User";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Location = new System.Drawing.Point(44, 68);
			this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(225, 1);
			this.panel1.TabIndex = 11;
			// 
			// inpt_incident_user
			// 
			this.inpt_incident_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.inpt_incident_user.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.inpt_incident_user.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.inpt_incident_user.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.inpt_incident_user.Location = new System.Drawing.Point(64, 45);
			this.inpt_incident_user.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.inpt_incident_user.Name = "inpt_incident_user";
			this.inpt_incident_user.Size = new System.Drawing.Size(182, 19);
			this.inpt_incident_user.TabIndex = 10;
			this.inpt_incident_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(402, 47);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 17);
			this.label2.TabIndex = 15;
			this.label2.Text = "Subject";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.Location = new System.Drawing.Point(440, 68);
			this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(225, 1);
			this.panel2.TabIndex = 14;
			// 
			// inpt_incident_subject
			// 
			this.inpt_incident_subject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.inpt_incident_subject.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.inpt_incident_subject.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.inpt_incident_subject.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.inpt_incident_subject.Location = new System.Drawing.Point(460, 45);
			this.inpt_incident_subject.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.inpt_incident_subject.Name = "inpt_incident_subject";
			this.inpt_incident_subject.Size = new System.Drawing.Size(182, 19);
			this.inpt_incident_subject.TabIndex = 13;
			this.inpt_incident_subject.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(402, 128);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(76, 17);
			this.label3.TabIndex = 18;
			this.label3.Text = "Due Date";
			// 
			// inpt_incident_dueDate
			// 
			this.inpt_incident_dueDate.Location = new System.Drawing.Point(490, 126);
			this.inpt_incident_dueDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.inpt_incident_dueDate.Name = "inpt_incident_dueDate";
			this.inpt_incident_dueDate.Size = new System.Drawing.Size(204, 20);
			this.inpt_incident_dueDate.TabIndex = 19;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(13, 129);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(149, 17);
			this.label4.TabIndex = 22;
			this.label4.Text = "Assigned Employee";
			// 
			// inpt_incident_assignedEmployee
			// 
			this.inpt_incident_assignedEmployee.BackColor = System.Drawing.Color.WhiteSmoke;
			this.inpt_incident_assignedEmployee.FormattingEnabled = true;
			this.inpt_incident_assignedEmployee.Location = new System.Drawing.Point(166, 124);
			this.inpt_incident_assignedEmployee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.inpt_incident_assignedEmployee.Name = "inpt_incident_assignedEmployee";
			this.inpt_incident_assignedEmployee.Size = new System.Drawing.Size(143, 21);
			this.inpt_incident_assignedEmployee.TabIndex = 23;
			this.inpt_incident_assignedEmployee.SelectedIndexChanged += new System.EventHandler(this.inpt_incident_assignedEmployee_SelectedIndexChanged);
			// 
			// inpt_incident_summary
			// 
			this.inpt_incident_summary.BackColor = System.Drawing.Color.White;
			this.inpt_incident_summary.Location = new System.Drawing.Point(16, 217);
			this.inpt_incident_summary.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.inpt_incident_summary.Name = "inpt_incident_summary";
			this.inpt_incident_summary.Size = new System.Drawing.Size(522, 158);
			this.inpt_incident_summary.TabIndex = 24;
			this.inpt_incident_summary.Text = "";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(13, 198);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(74, 17);
			this.label5.TabIndex = 25;
			this.label5.Text = "Summary";
			// 
			// btn_editIncident
			// 
			this.btn_editIncident.BackColor = System.Drawing.Color.Silver;
			this.btn_editIncident.Location = new System.Drawing.Point(568, 217);
			this.btn_editIncident.Margin = new System.Windows.Forms.Padding(2);
			this.btn_editIncident.Name = "btn_editIncident";
			this.btn_editIncident.Size = new System.Drawing.Size(203, 65);
			this.btn_editIncident.TabIndex = 26;
			this.btn_editIncident.Text = "Edit Incident";
			this.btn_editIncident.UseVisualStyleBackColor = false;
			this.btn_editIncident.Click += new System.EventHandler(this.btn_editIncident_Click);
			// 
			// AddIncident
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(781, 393);
			this.Controls.Add(this.btn_editIncident);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.inpt_incident_summary);
			this.Controls.Add(this.inpt_incident_assignedEmployee);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.inpt_incident_dueDate);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.inpt_incident_subject);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.inpt_incident_user);
			this.Controls.Add(this.btn_addIncident);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "AddIncident";
			this.Text = "AddIncident";
			this.Load += new System.EventHandler(this.AddIncident_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_addIncident;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox inpt_incident_user;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox inpt_incident_subject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker inpt_incident_dueDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox inpt_incident_assignedEmployee;
        private System.Windows.Forms.RichTextBox inpt_incident_summary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_editIncident;
    }
}