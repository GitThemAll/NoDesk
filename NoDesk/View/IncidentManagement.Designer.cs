namespace NoDesk.View
{
    partial class IncidentManagement
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
			this.leftPanel = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.copyLBL = new System.Windows.Forms.Label();
			this.usermanageBTN = new System.Windows.Forms.Button();
			this.incidentBTN = new System.Windows.Forms.Button();
			this.dashboardBTN = new System.Windows.Forms.Button();
			this.topLeftPanel = new System.Windows.Forms.Panel();
			this.servicedeskLBL = new System.Windows.Forms.Label();
			this.gardengroupLBL = new System.Windows.Forms.Label();
			this.topPanel = new System.Windows.Forms.Panel();
			this.titlelbl = new System.Windows.Forms.Label();
			this.searchtxt = new System.Windows.Forms.TextBox();
			this.btnAddIncident = new System.Windows.Forms.Button();
			this.GVIncident = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.user = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.summary = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btn_editIncident = new System.Windows.Forms.Button();
			this.leftPanel.SuspendLayout();
			this.panel1.SuspendLayout();
			this.topLeftPanel.SuspendLayout();
			this.topPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.GVIncident)).BeginInit();
			this.SuspendLayout();
			// 
			// leftPanel
			// 
			this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.leftPanel.Controls.Add(this.panel1);
			this.leftPanel.Controls.Add(this.usermanageBTN);
			this.leftPanel.Controls.Add(this.incidentBTN);
			this.leftPanel.Controls.Add(this.dashboardBTN);
			this.leftPanel.Controls.Add(this.topLeftPanel);
			this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
			this.leftPanel.Location = new System.Drawing.Point(0, 0);
			this.leftPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.leftPanel.Name = "leftPanel";
			this.leftPanel.Size = new System.Drawing.Size(250, 502);
			this.leftPanel.TabIndex = 1;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.panel1.Controls.Add(this.copyLBL);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 456);
			this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(250, 46);
			this.panel1.TabIndex = 4;
			// 
			// copyLBL
			// 
			this.copyLBL.AutoSize = true;
			this.copyLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.copyLBL.ForeColor = System.Drawing.Color.White;
			this.copyLBL.Location = new System.Drawing.Point(10, 15);
			this.copyLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.copyLBL.Name = "copyLBL";
			this.copyLBL.Size = new System.Drawing.Size(142, 24);
			this.copyLBL.TabIndex = 0;
			this.copyLBL.Text = "© 2020 Group 1";
			// 
			// usermanageBTN
			// 
			this.usermanageBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.usermanageBTN.Dock = System.Windows.Forms.DockStyle.Top;
			this.usermanageBTN.FlatAppearance.BorderSize = 0;
			this.usermanageBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.usermanageBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.usermanageBTN.ForeColor = System.Drawing.Color.White;
			this.usermanageBTN.Location = new System.Drawing.Point(0, 213);
			this.usermanageBTN.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.usermanageBTN.Name = "usermanageBTN";
			this.usermanageBTN.Size = new System.Drawing.Size(250, 67);
			this.usermanageBTN.TabIndex = 3;
			this.usermanageBTN.Text = "User Management";
			this.usermanageBTN.UseVisualStyleBackColor = false;
			this.usermanageBTN.Click += new System.EventHandler(this.usermanageBTN_Click);
			// 
			// incidentBTN
			// 
			this.incidentBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.incidentBTN.Dock = System.Windows.Forms.DockStyle.Top;
			this.incidentBTN.FlatAppearance.BorderSize = 0;
			this.incidentBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.incidentBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.incidentBTN.ForeColor = System.Drawing.Color.White;
			this.incidentBTN.Location = new System.Drawing.Point(0, 146);
			this.incidentBTN.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.incidentBTN.Name = "incidentBTN";
			this.incidentBTN.Size = new System.Drawing.Size(250, 67);
			this.incidentBTN.TabIndex = 2;
			this.incidentBTN.Text = "Incident Management";
			this.incidentBTN.UseVisualStyleBackColor = false;
			// 
			// dashboardBTN
			// 
			this.dashboardBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.dashboardBTN.Dock = System.Windows.Forms.DockStyle.Top;
			this.dashboardBTN.FlatAppearance.BorderSize = 0;
			this.dashboardBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.dashboardBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dashboardBTN.ForeColor = System.Drawing.Color.White;
			this.dashboardBTN.Location = new System.Drawing.Point(0, 79);
			this.dashboardBTN.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.dashboardBTN.Name = "dashboardBTN";
			this.dashboardBTN.Size = new System.Drawing.Size(250, 67);
			this.dashboardBTN.TabIndex = 1;
			this.dashboardBTN.Text = "Dashboard";
			this.dashboardBTN.UseVisualStyleBackColor = false;
			this.dashboardBTN.Click += new System.EventHandler(this.dashboardBTN_Click);
			// 
			// topLeftPanel
			// 
			this.topLeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
			this.topLeftPanel.Controls.Add(this.servicedeskLBL);
			this.topLeftPanel.Controls.Add(this.gardengroupLBL);
			this.topLeftPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.topLeftPanel.Location = new System.Drawing.Point(0, 0);
			this.topLeftPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.topLeftPanel.Name = "topLeftPanel";
			this.topLeftPanel.Size = new System.Drawing.Size(250, 79);
			this.topLeftPanel.TabIndex = 0;
			// 
			// servicedeskLBL
			// 
			this.servicedeskLBL.AutoSize = true;
			this.servicedeskLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.servicedeskLBL.ForeColor = System.Drawing.Color.White;
			this.servicedeskLBL.Location = new System.Drawing.Point(47, 45);
			this.servicedeskLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.servicedeskLBL.Name = "servicedeskLBL";
			this.servicedeskLBL.Size = new System.Drawing.Size(139, 25);
			this.servicedeskLBL.TabIndex = 1;
			this.servicedeskLBL.Text = "Service Desk";
			// 
			// gardengroupLBL
			// 
			this.gardengroupLBL.AutoSize = true;
			this.gardengroupLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gardengroupLBL.ForeColor = System.Drawing.Color.White;
			this.gardengroupLBL.Location = new System.Drawing.Point(16, 16);
			this.gardengroupLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.gardengroupLBL.Name = "gardengroupLBL";
			this.gardengroupLBL.Size = new System.Drawing.Size(222, 33);
			this.gardengroupLBL.TabIndex = 0;
			this.gardengroupLBL.Text = "Garden Group ";
			// 
			// topPanel
			// 
			this.topPanel.BackColor = System.Drawing.Color.White;
			this.topPanel.Controls.Add(this.titlelbl);
			this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.topPanel.Location = new System.Drawing.Point(250, 0);
			this.topPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.topPanel.Name = "topPanel";
			this.topPanel.Size = new System.Drawing.Size(768, 79);
			this.topPanel.TabIndex = 2;
			// 
			// titlelbl
			// 
			this.titlelbl.AutoSize = true;
			this.titlelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.titlelbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.titlelbl.Location = new System.Drawing.Point(31, 25);
			this.titlelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.titlelbl.Name = "titlelbl";
			this.titlelbl.Size = new System.Drawing.Size(323, 37);
			this.titlelbl.TabIndex = 0;
			this.titlelbl.Text = "Incident Management";
			// 
			// searchtxt
			// 
			this.searchtxt.Location = new System.Drawing.Point(288, 96);
			this.searchtxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.searchtxt.Name = "searchtxt";
			this.searchtxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.searchtxt.Size = new System.Drawing.Size(148, 20);
			this.searchtxt.TabIndex = 3;
			this.searchtxt.Text = "Search by ID";
			this.searchtxt.TextChanged += new System.EventHandler(this.searchtxt_TextChanged);
			// 
			// btnAddIncident
			// 
			this.btnAddIncident.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.btnAddIncident.Location = new System.Drawing.Point(869, 96);
			this.btnAddIncident.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnAddIncident.Name = "btnAddIncident";
			this.btnAddIncident.Size = new System.Drawing.Size(106, 32);
			this.btnAddIncident.TabIndex = 4;
			this.btnAddIncident.Text = "Add New Incident";
			this.btnAddIncident.UseVisualStyleBackColor = false;
			this.btnAddIncident.Click += new System.EventHandler(this.btnAddIncident_Click);
			// 
			// GVIncident
			// 
			this.GVIncident.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.GVIncident.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.user,
            this.Subject,
            this.date,
            this.status,
            this.summary,
            this.employee,
            this.dueDate});
			this.GVIncident.Location = new System.Drawing.Point(279, 210);
			this.GVIncident.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.GVIncident.Name = "GVIncident";
			this.GVIncident.RowHeadersWidth = 51;
			this.GVIncident.RowTemplate.Height = 24;
			this.GVIncident.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.GVIncident.Size = new System.Drawing.Size(719, 281);
			this.GVIncident.TabIndex = 5;
			this.GVIncident.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GVIncident_CellContentClick);
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
			// btn_editIncident
			// 
			this.btn_editIncident.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.btn_editIncident.Enabled = false;
			this.btn_editIncident.Location = new System.Drawing.Point(737, 96);
			this.btn_editIncident.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btn_editIncident.Name = "btn_editIncident";
			this.btn_editIncident.Size = new System.Drawing.Size(106, 32);
			this.btn_editIncident.TabIndex = 6;
			this.btn_editIncident.Text = "Edit Incident";
			this.btn_editIncident.UseVisualStyleBackColor = false;
			this.btn_editIncident.Click += new System.EventHandler(this.editIncident_Click);
			// 
			// IncidentManagement
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1018, 502);
			this.Controls.Add(this.btn_editIncident);
			this.Controls.Add(this.GVIncident);
			this.Controls.Add(this.btnAddIncident);
			this.Controls.Add(this.searchtxt);
			this.Controls.Add(this.topPanel);
			this.Controls.Add(this.leftPanel);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "IncidentManagement";
			this.Text = "UserManagement";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IncidentManagement_FormClosing);
			this.Load += new System.EventHandler(this.IncidentManagement_Load);
			this.leftPanel.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.topLeftPanel.ResumeLayout(false);
			this.topLeftPanel.PerformLayout();
			this.topPanel.ResumeLayout(false);
			this.topPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.GVIncident)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label copyLBL;
        private System.Windows.Forms.Button usermanageBTN;
        private System.Windows.Forms.Button incidentBTN;
        private System.Windows.Forms.Button dashboardBTN;
        private System.Windows.Forms.Panel topLeftPanel;
        private System.Windows.Forms.Label servicedeskLBL;
        private System.Windows.Forms.Label gardengroupLBL;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label titlelbl;
        private System.Windows.Forms.TextBox searchtxt;
        private System.Windows.Forms.Button btnAddIncident;
        private System.Windows.Forms.DataGridView GVIncident;
        private System.Windows.Forms.Button btn_editIncident;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
 //       private System.Windows.Forms.DataGridViewTextBoxColumn incident;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn summary;
        private System.Windows.Forms.DataGridViewTextBoxColumn employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn user;
    }
}