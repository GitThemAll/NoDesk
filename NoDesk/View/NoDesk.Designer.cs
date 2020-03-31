namespace NoDesk
{
	partial class NoDesk
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
			this.username = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.password = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.login_btn = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.logo = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
			this.SuspendLayout();
			// 
			// username
			// 
			this.username.BackColor = System.Drawing.Color.DarkGray;
			this.username.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.username.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.username.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.username.Location = new System.Drawing.Point(100, 261);
			this.username.Margin = new System.Windows.Forms.Padding(2);
			this.username.Name = "username";
			this.username.Size = new System.Drawing.Size(182, 19);
			this.username.TabIndex = 1;
			this.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Location = new System.Drawing.Point(79, 284);
			this.panel1.Margin = new System.Windows.Forms.Padding(2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(225, 1);
			this.panel1.TabIndex = 3;
			// 
			// password
			// 
			this.password.BackColor = System.Drawing.Color.DarkGray;
			this.password.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.password.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.password.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.password.Location = new System.Drawing.Point(100, 354);
			this.password.Margin = new System.Windows.Forms.Padding(2);
			this.password.Name = "password";
			this.password.Size = new System.Drawing.Size(182, 19);
			this.password.TabIndex = 5;
			this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.Location = new System.Drawing.Point(79, 378);
			this.panel2.Margin = new System.Windows.Forms.Padding(2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(225, 1);
			this.panel2.TabIndex = 6;
			// 
			// login_btn
			// 
			this.login_btn.BackColor = System.Drawing.Color.White;
			this.login_btn.Cursor = System.Windows.Forms.Cursors.Default;
			this.login_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.login_btn.ForeColor = System.Drawing.Color.Black;
			this.login_btn.Location = new System.Drawing.Point(116, 442);
			this.login_btn.Margin = new System.Windows.Forms.Padding(2);
			this.login_btn.Name = "login_btn";
			this.login_btn.Size = new System.Drawing.Size(150, 27);
			this.login_btn.TabIndex = 8;
			this.login_btn.Text = "LogIn";
			this.login_btn.UseVisualStyleBackColor = false;
			this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(46, 263);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 17);
			this.label1.TabIndex = 9;
			this.label1.Text = "Email";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(46, 357);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(77, 17);
			this.label2.TabIndex = 10;
			this.label2.Text = "Password";
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = global::NoDesk.Properties.Resources._41eaa115_18dd_47a8_aed7_ff755c8e72a6_200x200;
			this.pictureBox4.Location = new System.Drawing.Point(154, 309);
			this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(75, 41);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox4.TabIndex = 7;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::NoDesk.Properties.Resources._6aebbf0f_5f00_405b_9180_92d09d3cea94_200x200;
			this.pictureBox2.Location = new System.Drawing.Point(170, 215);
			this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(44, 41);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 4;
			this.pictureBox2.TabStop = false;
			// 
			// logo
			// 
			this.logo.Image = global::NoDesk.Properties.Resources.garden_group_logo;
			this.logo.Location = new System.Drawing.Point(82, 10);
			this.logo.Margin = new System.Windows.Forms.Padding(2);
			this.logo.Name = "logo";
			this.logo.Size = new System.Drawing.Size(200, 200);
			this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.logo.TabIndex = 0;
			this.logo.TabStop = false;
			// 
			// NoDesk
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkGray;
			this.ClientSize = new System.Drawing.Size(380, 582);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.login_btn);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.password);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.username);
			this.Controls.Add(this.logo);
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "NoDesk";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "NoDesk";
			this.TopMost = true;
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

