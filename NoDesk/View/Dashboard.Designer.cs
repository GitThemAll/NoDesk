namespace NoDesk
{
    partial class Dashboard
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
			this.dashboardLBL = new System.Windows.Forms.Label();
			this.circleProgressBar1 = new CircularProgressBar.CircularProgressBar();
			this.unresolvedLBL = new System.Windows.Forms.Label();
			this.ticketsopenLBL = new System.Windows.Forms.Label();
			this.circleProgressBar2 = new CircularProgressBar.CircularProgressBar();
			this.attentionLBL = new System.Windows.Forms.Label();
			this.deadlineLBL = new System.Windows.Forms.Label();
			this.leftPanel.SuspendLayout();
			this.panel1.SuspendLayout();
			this.topLeftPanel.SuspendLayout();
			this.topPanel.SuspendLayout();
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
			this.leftPanel.Size = new System.Drawing.Size(261, 565);
			this.leftPanel.TabIndex = 0;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.panel1.Controls.Add(this.copyLBL);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 508);
			this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(261, 57);
			this.panel1.TabIndex = 4;
			// 
			// copyLBL
			// 
			this.copyLBL.AutoSize = true;
			this.copyLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.copyLBL.ForeColor = System.Drawing.Color.White;
			this.copyLBL.Location = new System.Drawing.Point(14, 18);
			this.copyLBL.Name = "copyLBL";
			this.copyLBL.Size = new System.Drawing.Size(142, 24);
			this.copyLBL.TabIndex = 0;
			this.copyLBL.Text = "© 2020 Group 1";
			// 
			// usermanageBTN
			// 
			this.usermanageBTN.Dock = System.Windows.Forms.DockStyle.Top;
			this.usermanageBTN.FlatAppearance.BorderSize = 0;
			this.usermanageBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.usermanageBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.usermanageBTN.ForeColor = System.Drawing.Color.White;
			this.usermanageBTN.Location = new System.Drawing.Point(0, 261);
			this.usermanageBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.usermanageBTN.Name = "usermanageBTN";
			this.usermanageBTN.Size = new System.Drawing.Size(261, 82);
			this.usermanageBTN.TabIndex = 3;
			this.usermanageBTN.Text = "User Management";
			this.usermanageBTN.UseVisualStyleBackColor = true;
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
			this.incidentBTN.Size = new System.Drawing.Size(261, 82);
			this.incidentBTN.TabIndex = 2;
			this.incidentBTN.Text = "Incident Management";
			this.incidentBTN.UseVisualStyleBackColor = true;
			// 
			// dashboardBTN
			// 
			this.dashboardBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.dashboardBTN.Dock = System.Windows.Forms.DockStyle.Top;
			this.dashboardBTN.FlatAppearance.BorderSize = 0;
			this.dashboardBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.dashboardBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dashboardBTN.ForeColor = System.Drawing.Color.White;
			this.dashboardBTN.Location = new System.Drawing.Point(0, 97);
			this.dashboardBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.dashboardBTN.Name = "dashboardBTN";
			this.dashboardBTN.Size = new System.Drawing.Size(261, 82);
			this.dashboardBTN.TabIndex = 1;
			this.dashboardBTN.Text = "Dashboard";
			this.dashboardBTN.UseVisualStyleBackColor = false;
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
			this.topLeftPanel.Size = new System.Drawing.Size(261, 97);
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
			this.servicedeskLBL.Size = new System.Drawing.Size(139, 25);
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
			this.gardengroupLBL.Size = new System.Drawing.Size(222, 33);
			this.gardengroupLBL.TabIndex = 0;
			this.gardengroupLBL.Text = "Garden Group ";
			// 
			// topPanel
			// 
			this.topPanel.BackColor = System.Drawing.Color.White;
			this.topPanel.Controls.Add(this.dashboardLBL);
			this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.topPanel.Location = new System.Drawing.Point(261, 0);
			this.topPanel.Margin = new System.Windows.Forms.Padding(2);
			this.topPanel.Name = "topPanel";
			this.topPanel.Size = new System.Drawing.Size(801, 97);
			this.topPanel.TabIndex = 1;
			// 
			// dashboardLBL
			// 
			this.dashboardLBL.AutoSize = true;
			this.dashboardLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dashboardLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.dashboardLBL.Location = new System.Drawing.Point(41, 31);
			this.dashboardLBL.Name = "dashboardLBL";
			this.dashboardLBL.Size = new System.Drawing.Size(175, 37);
			this.dashboardLBL.TabIndex = 0;
			this.dashboardLBL.Text = "Dashboard";
			// 
			// circleProgressBar1
			// 
			this.circleProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
			this.circleProgressBar1.AnimationSpeed = 500;
			this.circleProgressBar1.BackColor = System.Drawing.Color.Transparent;
			this.circleProgressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.circleProgressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.circleProgressBar1.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.circleProgressBar1.InnerMargin = 2;
			this.circleProgressBar1.InnerWidth = -1;
			this.circleProgressBar1.Location = new System.Drawing.Point(320, 227);
			this.circleProgressBar1.MarqueeAnimationSpeed = 2000;
			this.circleProgressBar1.Name = "circleProgressBar1";
			this.circleProgressBar1.OuterColor = System.Drawing.Color.Gray;
			this.circleProgressBar1.OuterMargin = -25;
			this.circleProgressBar1.OuterWidth = 26;
			this.circleProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
			this.circleProgressBar1.ProgressWidth = 15;
			this.circleProgressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.circleProgressBar1.Size = new System.Drawing.Size(270, 270);
			this.circleProgressBar1.StartAngle = 270;
			this.circleProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
			this.circleProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
			this.circleProgressBar1.SubscriptText = "";
			this.circleProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
			this.circleProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
			this.circleProgressBar1.SuperscriptText = "";
			this.circleProgressBar1.TabIndex = 2;
			this.circleProgressBar1.Text = "7/15";
			this.circleProgressBar1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
			this.circleProgressBar1.Value = 45;
			// 
			// unresolvedLBL
			// 
			this.unresolvedLBL.AutoSize = true;
			this.unresolvedLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.unresolvedLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.unresolvedLBL.Location = new System.Drawing.Point(303, 132);
			this.unresolvedLBL.Name = "unresolvedLBL";
			this.unresolvedLBL.Size = new System.Drawing.Size(308, 33);
			this.unresolvedLBL.TabIndex = 3;
			this.unresolvedLBL.Text = "Unresolved Incidents";
			// 
			// ticketsopenLBL
			// 
			this.ticketsopenLBL.AutoSize = true;
			this.ticketsopenLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ticketsopenLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.ticketsopenLBL.Location = new System.Drawing.Point(358, 179);
			this.ticketsopenLBL.Name = "ticketsopenLBL";
			this.ticketsopenLBL.Size = new System.Drawing.Size(190, 20);
			this.ticketsopenLBL.TabIndex = 4;
			this.ticketsopenLBL.Text = "All Tickets Currently Open";
			// 
			// circleProgressBar2
			// 
			this.circleProgressBar2.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
			this.circleProgressBar2.AnimationSpeed = 500;
			this.circleProgressBar2.BackColor = System.Drawing.Color.Transparent;
			this.circleProgressBar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.circleProgressBar2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.circleProgressBar2.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.circleProgressBar2.InnerMargin = 2;
			this.circleProgressBar2.InnerWidth = -1;
			this.circleProgressBar2.Location = new System.Drawing.Point(711, 227);
			this.circleProgressBar2.MarqueeAnimationSpeed = 2000;
			this.circleProgressBar2.Name = "circleProgressBar2";
			this.circleProgressBar2.OuterColor = System.Drawing.Color.Gray;
			this.circleProgressBar2.OuterMargin = -25;
			this.circleProgressBar2.OuterWidth = 26;
			this.circleProgressBar2.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.circleProgressBar2.ProgressWidth = 15;
			this.circleProgressBar2.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.circleProgressBar2.Size = new System.Drawing.Size(270, 270);
			this.circleProgressBar2.StartAngle = 270;
			this.circleProgressBar2.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
			this.circleProgressBar2.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
			this.circleProgressBar2.SubscriptText = "";
			this.circleProgressBar2.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
			this.circleProgressBar2.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
			this.circleProgressBar2.SuperscriptText = "";
			this.circleProgressBar2.TabIndex = 5;
			this.circleProgressBar2.Text = "1";
			this.circleProgressBar2.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
			this.circleProgressBar2.Value = 60;
			// 
			// attentionLBL
			// 
			this.attentionLBL.AutoSize = true;
			this.attentionLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.attentionLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.attentionLBL.Location = new System.Drawing.Point(695, 179);
			this.attentionLBL.Name = "attentionLBL";
			this.attentionLBL.Size = new System.Drawing.Size(297, 20);
			this.attentionLBL.TabIndex = 7;
			this.attentionLBL.Text = "These Tickets Need Immediate Attention";
			// 
			// deadlineLBL
			// 
			this.deadlineLBL.AutoSize = true;
			this.deadlineLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.deadlineLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.deadlineLBL.Location = new System.Drawing.Point(687, 132);
			this.deadlineLBL.Name = "deadlineLBL";
			this.deadlineLBL.Size = new System.Drawing.Size(344, 33);
			this.deadlineLBL.TabIndex = 6;
			this.deadlineLBL.Text = "Incidents Past Deadline";
			// 
			// Dashboard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.ClientSize = new System.Drawing.Size(1062, 565);
			this.Controls.Add(this.attentionLBL);
			this.Controls.Add(this.deadlineLBL);
			this.Controls.Add(this.circleProgressBar2);
			this.Controls.Add(this.ticketsopenLBL);
			this.Controls.Add(this.unresolvedLBL);
			this.Controls.Add(this.circleProgressBar1);
			this.Controls.Add(this.topPanel);
			this.Controls.Add(this.leftPanel);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "Dashboard";
			this.Text = "Dashboard";
			this.leftPanel.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.topLeftPanel.ResumeLayout(false);
			this.topLeftPanel.PerformLayout();
			this.topPanel.ResumeLayout(false);
			this.topPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel topLeftPanel;
        private System.Windows.Forms.Label servicedeskLBL;
        private System.Windows.Forms.Label gardengroupLBL;
        private System.Windows.Forms.Button dashboardBTN;
        private System.Windows.Forms.Button usermanageBTN;
        private System.Windows.Forms.Button incidentBTN;
        private System.Windows.Forms.Label dashboardLBL;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label copyLBL;
        private CircularProgressBar.CircularProgressBar circleProgressBar1;
        private System.Windows.Forms.Label unresolvedLBL;
        private System.Windows.Forms.Label ticketsopenLBL;
        private CircularProgressBar.CircularProgressBar circleProgressBar2;
        private System.Windows.Forms.Label attentionLBL;
        private System.Windows.Forms.Label deadlineLBL;
    }
}