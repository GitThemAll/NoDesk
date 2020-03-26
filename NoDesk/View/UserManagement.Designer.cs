namespace NoDesk.View
{
    partial class UserManagement
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
            this.btnadduser = new System.Windows.Forms.Button();
            this.GVUser = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketsid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.topLeftPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVUser)).BeginInit();
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
            this.leftPanel.Margin = new System.Windows.Forms.Padding(2);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(289, 581);
            this.leftPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.copyLBL);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 524);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 57);
            this.panel1.TabIndex = 4;
            // 
            // copyLBL
            // 
            this.copyLBL.AutoSize = true;
            this.copyLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyLBL.ForeColor = System.Drawing.Color.White;
            this.copyLBL.Location = new System.Drawing.Point(14, 18);
            this.copyLBL.Name = "copyLBL";
            this.copyLBL.Size = new System.Drawing.Size(183, 29);
            this.copyLBL.TabIndex = 0;
            this.copyLBL.Text = "© 2020 Group 1";
            // 
            // usermanageBTN
            // 
            this.usermanageBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.usermanageBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.usermanageBTN.FlatAppearance.BorderSize = 0;
            this.usermanageBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usermanageBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usermanageBTN.ForeColor = System.Drawing.Color.White;
            this.usermanageBTN.Location = new System.Drawing.Point(0, 261);
            this.usermanageBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.usermanageBTN.Name = "usermanageBTN";
            this.usermanageBTN.Size = new System.Drawing.Size(289, 82);
            this.usermanageBTN.TabIndex = 3;
            this.usermanageBTN.Text = "User Management";
            this.usermanageBTN.UseVisualStyleBackColor = false;
            this.usermanageBTN.Click += new System.EventHandler(this.usermanageBTN_Click);
            // 
            // incidentBTN
            // 
            this.incidentBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.incidentBTN.FlatAppearance.BorderSize = 0;
            this.incidentBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.incidentBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incidentBTN.ForeColor = System.Drawing.Color.White;
            this.incidentBTN.Location = new System.Drawing.Point(0, 179);
            this.incidentBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.incidentBTN.Name = "incidentBTN";
            this.incidentBTN.Size = new System.Drawing.Size(289, 82);
            this.incidentBTN.TabIndex = 2;
            this.incidentBTN.Text = "Incident Management";
            this.incidentBTN.UseVisualStyleBackColor = true;
            // 
            // dashboardBTN
            // 
            this.dashboardBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dashboardBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.dashboardBTN.FlatAppearance.BorderSize = 0;
            this.dashboardBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardBTN.ForeColor = System.Drawing.Color.White;
            this.dashboardBTN.Location = new System.Drawing.Point(0, 97);
            this.dashboardBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dashboardBTN.Name = "dashboardBTN";
            this.dashboardBTN.Size = new System.Drawing.Size(289, 82);
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
            this.topLeftPanel.Margin = new System.Windows.Forms.Padding(2);
            this.topLeftPanel.Name = "topLeftPanel";
            this.topLeftPanel.Size = new System.Drawing.Size(289, 97);
            this.topLeftPanel.TabIndex = 0;
            // 
            // servicedeskLBL
            // 
            this.servicedeskLBL.AutoSize = true;
            this.servicedeskLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servicedeskLBL.ForeColor = System.Drawing.Color.White;
            this.servicedeskLBL.Location = new System.Drawing.Point(63, 55);
            this.servicedeskLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.servicedeskLBL.Name = "servicedeskLBL";
            this.servicedeskLBL.Size = new System.Drawing.Size(175, 31);
            this.servicedeskLBL.TabIndex = 1;
            this.servicedeskLBL.Text = "Service Desk";
            // 
            // gardengroupLBL
            // 
            this.gardengroupLBL.AutoSize = true;
            this.gardengroupLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gardengroupLBL.ForeColor = System.Drawing.Color.White;
            this.gardengroupLBL.Location = new System.Drawing.Point(21, 20);
            this.gardengroupLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gardengroupLBL.Name = "gardengroupLBL";
            this.gardengroupLBL.Size = new System.Drawing.Size(280, 42);
            this.gardengroupLBL.TabIndex = 0;
            this.gardengroupLBL.Text = "Garden Group ";
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.White;
            this.topPanel.Controls.Add(this.titlelbl);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(289, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(752, 97);
            this.topPanel.TabIndex = 2;
            // 
            // titlelbl
            // 
            this.titlelbl.AutoSize = true;
            this.titlelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlelbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.titlelbl.Location = new System.Drawing.Point(41, 31);
            this.titlelbl.Name = "titlelbl";
            this.titlelbl.Size = new System.Drawing.Size(346, 46);
            this.titlelbl.TabIndex = 0;
            this.titlelbl.Text = "User Management";
            // 
            // searchtxt
            // 
            this.searchtxt.Location = new System.Drawing.Point(338, 132);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.searchtxt.Size = new System.Drawing.Size(196, 22);
            this.searchtxt.TabIndex = 3;
            this.searchtxt.Text = "Search by Email";
            this.searchtxt.TextChanged += new System.EventHandler(this.searchtxt_TextChanged);
            // 
            // btnadduser
            // 
            this.btnadduser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnadduser.Location = new System.Drawing.Point(815, 132);
            this.btnadduser.Name = "btnadduser";
            this.btnadduser.Size = new System.Drawing.Size(142, 40);
            this.btnadduser.TabIndex = 4;
            this.btnadduser.Text = "Add New User";
            this.btnadduser.UseVisualStyleBackColor = false;
            this.btnadduser.Click += new System.EventHandler(this.btnadduser_Click);
            // 
            // GVUser
            // 
            this.GVUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Email,
            this.FirstName,
            this.LastName,
            this.ticketsid});
            this.GVUser.Location = new System.Drawing.Point(338, 179);
            this.GVUser.Name = "GVUser";
            this.GVUser.RowHeadersWidth = 51;
            this.GVUser.RowTemplate.Height = 24;
            this.GVUser.Size = new System.Drawing.Size(619, 294);
            this.GVUser.TabIndex = 5;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 50;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 125;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "First Name";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            this.FirstName.Width = 125;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Last Name";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            this.LastName.Width = 125;
            // 
            // ticketsid
            // 
            this.ticketsid.HeaderText = "#Tickets";
            this.ticketsid.MinimumWidth = 6;
            this.ticketsid.Name = "ticketsid";
            this.ticketsid.Width = 125;
            // 
            // UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 581);
            this.Controls.Add(this.GVUser);
            this.Controls.Add(this.btnadduser);
            this.Controls.Add(this.searchtxt);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.leftPanel);
            this.Name = "UserManagement";
            this.Text = "UserManagement";
            this.Load += new System.EventHandler(this.UserManagement_Load);
            this.leftPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.topLeftPanel.ResumeLayout(false);
            this.topLeftPanel.PerformLayout();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVUser)).EndInit();
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
        private System.Windows.Forms.Button btnadduser;
        private System.Windows.Forms.DataGridView GVUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketsid;
    }
}