namespace NoDesk.View
{
	partial class EmployeeDashboardForm
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
			this.GVspecificEmployeeIncident = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.user = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.summary = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.GVspecificEmployeeIncident)).BeginInit();
			this.SuspendLayout();
			// 
			// GVspecificEmployeeIncident
			// 
			this.GVspecificEmployeeIncident.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.GVspecificEmployeeIncident.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.user,
            this.Subject,
            this.date,
            this.status,
            this.summary,
            this.employee,
            this.dueDate});
			this.GVspecificEmployeeIncident.Location = new System.Drawing.Point(122, 121);
			this.GVspecificEmployeeIncident.Margin = new System.Windows.Forms.Padding(2);
			this.GVspecificEmployeeIncident.Name = "GVspecificEmployeeIncident";
			this.GVspecificEmployeeIncident.RowHeadersWidth = 51;
			this.GVspecificEmployeeIncident.RowTemplate.Height = 24;
			this.GVspecificEmployeeIncident.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.GVspecificEmployeeIncident.Size = new System.Drawing.Size(1087, 451);
			this.GVspecificEmployeeIncident.TabIndex = 6;
			this.GVspecificEmployeeIncident.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GVIncident_CellContentClick);
			// 
			// ID
			// 
			this.ID.HeaderText = "ID";
			this.ID.MinimumWidth = 6;
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Width = 160;
			// 
			// user
			// 
			this.user.HeaderText = "User";
			this.user.MinimumWidth = 6;
			this.user.Name = "user";
			this.user.ReadOnly = true;
			this.user.Width = 125;
			// 
			// Subject
			// 
			this.Subject.HeaderText = "Subject";
			this.Subject.MinimumWidth = 6;
			this.Subject.Name = "Subject";
			this.Subject.ReadOnly = true;
			this.Subject.Width = 125;
			// 
			// date
			// 
			this.date.HeaderText = "Date";
			this.date.MinimumWidth = 6;
			this.date.Name = "date";
			this.date.ReadOnly = true;
			this.date.Width = 125;
			// 
			// status
			// 
			this.status.HeaderText = "Status";
			this.status.MinimumWidth = 6;
			this.status.Name = "status";
			this.status.ReadOnly = true;
			this.status.Width = 125;
			// 
			// summary
			// 
			this.summary.HeaderText = "Summary";
			this.summary.MinimumWidth = 6;
			this.summary.Name = "summary";
			this.summary.ReadOnly = true;
			this.summary.Width = 125;
			// 
			// employee
			// 
			this.employee.HeaderText = "Assigned Employee";
			this.employee.MinimumWidth = 6;
			this.employee.Name = "employee";
			this.employee.ReadOnly = true;
			this.employee.Width = 125;
			// 
			// dueDate
			// 
			this.dueDate.HeaderText = "Due Date";
			this.dueDate.MinimumWidth = 6;
			this.dueDate.Name = "dueDate";
			this.dueDate.ReadOnly = true;
			this.dueDate.Width = 125;
			// 
			// EmployeeDashboardForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1352, 600);
			this.Controls.Add(this.GVspecificEmployeeIncident);
			this.Name = "EmployeeDashboardForm";
			this.Text = "EmployeeDashboardForm";
			this.Load += new System.EventHandler(this.EmployeeDashboardForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.GVspecificEmployeeIncident)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView GVspecificEmployeeIncident;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn user;
		private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
		private System.Windows.Forms.DataGridViewTextBoxColumn date;
		private System.Windows.Forms.DataGridViewTextBoxColumn status;
		private System.Windows.Forms.DataGridViewTextBoxColumn summary;
		private System.Windows.Forms.DataGridViewTextBoxColumn employee;
		private System.Windows.Forms.DataGridViewTextBoxColumn dueDate;
	}
}