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
            this.UnResolvedIncidentsProgressBar = new CircularProgressBar.CircularProgressBar();
            this.unresolvedLBL = new System.Windows.Forms.Label();
            this.ticketsopenLBL = new System.Windows.Forms.Label();
            this.PastIncidentsProgressBar = new CircularProgressBar.CircularProgressBar();
            this.attentionLBL = new System.Windows.Forms.Label();
            this.deadlineLBL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ResolvedIncidentsProgressBar = new CircularProgressBar.CircularProgressBar();
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
            this.leftPanel.Size = new System.Drawing.Size(504, 966);
            this.leftPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.copyLBL);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 866);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(504, 100);
            this.panel1.TabIndex = 4;
            // 
            // copyLBL
            // 
            this.copyLBL.AutoSize = true;
            this.copyLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyLBL.ForeColor = System.Drawing.Color.White;
            this.copyLBL.Location = new System.Drawing.Point(11, 29);
            this.copyLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.copyLBL.Name = "copyLBL";
            this.copyLBL.Size = new System.Drawing.Size(289, 44);
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
            this.usermanageBTN.Location = new System.Drawing.Point(0, 430);
            this.usermanageBTN.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.usermanageBTN.Name = "usermanageBTN";
            this.usermanageBTN.Size = new System.Drawing.Size(504, 139);
            this.usermanageBTN.TabIndex = 3;
            this.usermanageBTN.Text = "User Management";
            this.usermanageBTN.UseVisualStyleBackColor = true;
            this.usermanageBTN.Click += new System.EventHandler(this.usermanageBTN_Click);
            // 
            // incidentBTN
            // 
            this.incidentBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.incidentBTN.FlatAppearance.BorderSize = 0;
            this.incidentBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.incidentBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incidentBTN.ForeColor = System.Drawing.Color.White;
            this.incidentBTN.Location = new System.Drawing.Point(0, 291);
            this.incidentBTN.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.incidentBTN.Name = "incidentBTN";
            this.incidentBTN.Size = new System.Drawing.Size(504, 139);
            this.incidentBTN.TabIndex = 2;
            this.incidentBTN.Text = "Incident Management";
            this.incidentBTN.UseVisualStyleBackColor = true;
            this.incidentBTN.Click += new System.EventHandler(this.incidentBTN_Click);
            // 
            // dashboardBTN
            // 
            this.dashboardBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.dashboardBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.dashboardBTN.FlatAppearance.BorderSize = 0;
            this.dashboardBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardBTN.ForeColor = System.Drawing.Color.White;
            this.dashboardBTN.Location = new System.Drawing.Point(0, 152);
            this.dashboardBTN.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dashboardBTN.Name = "dashboardBTN";
            this.dashboardBTN.Size = new System.Drawing.Size(504, 139);
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
            this.topLeftPanel.Size = new System.Drawing.Size(504, 152);
            this.topLeftPanel.TabIndex = 0;
            // 
            // servicedeskLBL
            // 
            this.servicedeskLBL.AutoSize = true;
            this.servicedeskLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servicedeskLBL.ForeColor = System.Drawing.Color.White;
            this.servicedeskLBL.Location = new System.Drawing.Point(97, 91);
            this.servicedeskLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.servicedeskLBL.Name = "servicedeskLBL";
            this.servicedeskLBL.Size = new System.Drawing.Size(266, 48);
            this.servicedeskLBL.TabIndex = 1;
            this.servicedeskLBL.Text = "Service Desk";
            // 
            // gardengroupLBL
            // 
            this.gardengroupLBL.AutoSize = true;
            this.gardengroupLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gardengroupLBL.ForeColor = System.Drawing.Color.White;
            this.gardengroupLBL.Location = new System.Drawing.Point(34, 24);
            this.gardengroupLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gardengroupLBL.Name = "gardengroupLBL";
            this.gardengroupLBL.Size = new System.Drawing.Size(424, 67);
            this.gardengroupLBL.TabIndex = 0;
            this.gardengroupLBL.Text = "Garden Group ";
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.White;
            this.topPanel.Controls.Add(this.dashboardLBL);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(504, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1532, 152);
            this.topPanel.TabIndex = 1;
            // 
            // dashboardLBL
            // 
            this.dashboardLBL.AutoSize = true;
            this.dashboardLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dashboardLBL.Location = new System.Drawing.Point(15, 40);
            this.dashboardLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dashboardLBL.Name = "dashboardLBL";
            this.dashboardLBL.Size = new System.Drawing.Size(347, 73);
            this.dashboardLBL.TabIndex = 0;
            this.dashboardLBL.Text = "Dashboard";
            // 
            // UnResolvedIncidentsProgressBar
            // 
            this.UnResolvedIncidentsProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.UnResolvedIncidentsProgressBar.AnimationSpeed = 500;
            this.UnResolvedIncidentsProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.UnResolvedIncidentsProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnResolvedIncidentsProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UnResolvedIncidentsProgressBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.UnResolvedIncidentsProgressBar.InnerMargin = 2;
            this.UnResolvedIncidentsProgressBar.InnerWidth = -1;
            this.UnResolvedIncidentsProgressBar.Location = new System.Drawing.Point(1067, 406);
            this.UnResolvedIncidentsProgressBar.Margin = new System.Windows.Forms.Padding(2);
            this.UnResolvedIncidentsProgressBar.MarqueeAnimationSpeed = 2000;
            this.UnResolvedIncidentsProgressBar.Name = "UnResolvedIncidentsProgressBar";
            this.UnResolvedIncidentsProgressBar.OuterColor = System.Drawing.Color.Gray;
            this.UnResolvedIncidentsProgressBar.OuterMargin = -25;
            this.UnResolvedIncidentsProgressBar.OuterWidth = 26;
            this.UnResolvedIncidentsProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.UnResolvedIncidentsProgressBar.ProgressWidth = 15;
            this.UnResolvedIncidentsProgressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnResolvedIncidentsProgressBar.Size = new System.Drawing.Size(350, 350);
            this.UnResolvedIncidentsProgressBar.StartAngle = 270;
            this.UnResolvedIncidentsProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.UnResolvedIncidentsProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.UnResolvedIncidentsProgressBar.SubscriptText = "";
            this.UnResolvedIncidentsProgressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.UnResolvedIncidentsProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.UnResolvedIncidentsProgressBar.SuperscriptText = "";
            this.UnResolvedIncidentsProgressBar.TabIndex = 2;
            this.UnResolvedIncidentsProgressBar.Text = "7/15";
            this.UnResolvedIncidentsProgressBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.UnResolvedIncidentsProgressBar.Value = 60;
            // 
            // unresolvedLBL
            // 
            this.unresolvedLBL.AutoSize = true;
            this.unresolvedLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.75F, System.Drawing.FontStyle.Bold);
            this.unresolvedLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.unresolvedLBL.Location = new System.Drawing.Point(1060, 291);
            this.unresolvedLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.unresolvedLBL.Name = "unresolvedLBL";
            this.unresolvedLBL.Size = new System.Drawing.Size(387, 42);
            this.unresolvedLBL.TabIndex = 3;
            this.unresolvedLBL.Text = "Unresolved Incidents";
            // 
            // ticketsopenLBL
            // 
            this.ticketsopenLBL.AutoSize = true;
            this.ticketsopenLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ticketsopenLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ticketsopenLBL.Location = new System.Drawing.Point(1104, 327);
            this.ticketsopenLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ticketsopenLBL.Name = "ticketsopenLBL";
            this.ticketsopenLBL.Size = new System.Drawing.Size(292, 29);
            this.ticketsopenLBL.TabIndex = 4;
            this.ticketsopenLBL.Text = "All Tickets Currently Open";
            // 
            // PastIncidentsProgressBar
            // 
            this.PastIncidentsProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.PastIncidentsProgressBar.AnimationSpeed = 500;
            this.PastIncidentsProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.PastIncidentsProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PastIncidentsProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PastIncidentsProgressBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PastIncidentsProgressBar.InnerMargin = 2;
            this.PastIncidentsProgressBar.InnerWidth = -1;
            this.PastIncidentsProgressBar.Location = new System.Drawing.Point(1545, 406);
            this.PastIncidentsProgressBar.Margin = new System.Windows.Forms.Padding(2);
            this.PastIncidentsProgressBar.MarqueeAnimationSpeed = 2000;
            this.PastIncidentsProgressBar.Name = "PastIncidentsProgressBar";
            this.PastIncidentsProgressBar.OuterColor = System.Drawing.Color.Gray;
            this.PastIncidentsProgressBar.OuterMargin = -25;
            this.PastIncidentsProgressBar.OuterWidth = 26;
            this.PastIncidentsProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PastIncidentsProgressBar.ProgressWidth = 15;
            this.PastIncidentsProgressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PastIncidentsProgressBar.Size = new System.Drawing.Size(350, 350);
            this.PastIncidentsProgressBar.StartAngle = 270;
            this.PastIncidentsProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.PastIncidentsProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.PastIncidentsProgressBar.SubscriptText = "";
            this.PastIncidentsProgressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.PastIncidentsProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.PastIncidentsProgressBar.SuperscriptText = "";
            this.PastIncidentsProgressBar.TabIndex = 5;
            this.PastIncidentsProgressBar.Text = "1";
            this.PastIncidentsProgressBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.PastIncidentsProgressBar.Value = 60;
            // 
            // attentionLBL
            // 
            this.attentionLBL.AutoSize = true;
            this.attentionLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.attentionLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.attentionLBL.Location = new System.Drawing.Point(1521, 339);
            this.attentionLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.attentionLBL.Name = "attentionLBL";
            this.attentionLBL.Size = new System.Drawing.Size(450, 29);
            this.attentionLBL.TabIndex = 7;
            this.attentionLBL.Text = "These Tickets Need Immediate Attention";
            // 
            // deadlineLBL
            // 
            this.deadlineLBL.AutoSize = true;
            this.deadlineLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.75F, System.Drawing.FontStyle.Bold);
            this.deadlineLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.deadlineLBL.Location = new System.Drawing.Point(1538, 291);
            this.deadlineLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.deadlineLBL.Name = "deadlineLBL";
            this.deadlineLBL.Size = new System.Drawing.Size(433, 42);
            this.deadlineLBL.TabIndex = 6;
            this.deadlineLBL.Text = "Incidents Past Deadline";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label1.Location = new System.Drawing.Point(630, 327);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "All Tickets Currently Open";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label2.Location = new System.Drawing.Point(611, 291);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(352, 42);
            this.label2.TabIndex = 9;
            this.label2.Text = "Resolved Incidents";
            // 
            // ResolvedIncidentsProgressBar
            // 
            this.ResolvedIncidentsProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.ResolvedIncidentsProgressBar.AnimationSpeed = 500;
            this.ResolvedIncidentsProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.ResolvedIncidentsProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResolvedIncidentsProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ResolvedIncidentsProgressBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ResolvedIncidentsProgressBar.InnerMargin = 2;
            this.ResolvedIncidentsProgressBar.InnerWidth = -1;
            this.ResolvedIncidentsProgressBar.Location = new System.Drawing.Point(618, 406);
            this.ResolvedIncidentsProgressBar.Margin = new System.Windows.Forms.Padding(2);
            this.ResolvedIncidentsProgressBar.MarqueeAnimationSpeed = 2000;
            this.ResolvedIncidentsProgressBar.Name = "ResolvedIncidentsProgressBar";
            this.ResolvedIncidentsProgressBar.OuterColor = System.Drawing.Color.Gray;
            this.ResolvedIncidentsProgressBar.OuterMargin = -25;
            this.ResolvedIncidentsProgressBar.OuterWidth = 26;
            this.ResolvedIncidentsProgressBar.ProgressColor = System.Drawing.Color.SeaGreen;
            this.ResolvedIncidentsProgressBar.ProgressWidth = 15;
            this.ResolvedIncidentsProgressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResolvedIncidentsProgressBar.Size = new System.Drawing.Size(350, 350);
            this.ResolvedIncidentsProgressBar.StartAngle = 270;
            this.ResolvedIncidentsProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.ResolvedIncidentsProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.ResolvedIncidentsProgressBar.SubscriptText = "";
            this.ResolvedIncidentsProgressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.ResolvedIncidentsProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.ResolvedIncidentsProgressBar.SuperscriptText = "";
            this.ResolvedIncidentsProgressBar.TabIndex = 8;
            this.ResolvedIncidentsProgressBar.Text = "7/15";
            this.ResolvedIncidentsProgressBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.ResolvedIncidentsProgressBar.Value = 60;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(2036, 966);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ResolvedIncidentsProgressBar);
            this.Controls.Add(this.attentionLBL);
            this.Controls.Add(this.deadlineLBL);
            this.Controls.Add(this.PastIncidentsProgressBar);
            this.Controls.Add(this.ticketsopenLBL);
            this.Controls.Add(this.unresolvedLBL);
            this.Controls.Add(this.UnResolvedIncidentsProgressBar);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.leftPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dashboard_FormClosing);
            this.Load += new System.EventHandler(this.Dashboard_Load);
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
        private CircularProgressBar.CircularProgressBar UnResolvedIncidentsProgressBar;
        private System.Windows.Forms.Label unresolvedLBL;
        private System.Windows.Forms.Label ticketsopenLBL;
        private CircularProgressBar.CircularProgressBar PastIncidentsProgressBar;
        private System.Windows.Forms.Label attentionLBL;
        private System.Windows.Forms.Label deadlineLBL;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private CircularProgressBar.CircularProgressBar ResolvedIncidentsProgressBar;
	}
}