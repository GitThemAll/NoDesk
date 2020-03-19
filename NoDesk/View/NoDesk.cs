using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoDesk
{
	public partial class NoDesk : Form
	{
		private Dashboard dashboard;
		public NoDesk()
		{
			InitializeComponent();
			
		}

        private void login_btn_Click(object sender, EventArgs e)
        {
	        try
	        {
				string usernameValue = !string.IsNullOrEmpty(username.Text.Trim()) ? username.Text.Trim() : string.Empty;
		        string passwordValue = !string.IsNullOrEmpty(password.Text.Trim()) ? password.Text.Trim() : string.Empty;
		        if (usernameValue == string.Empty || passwordValue == string.Empty)
		        {
			        throw new Exception(usernameValue == string.Empty && passwordValue == string.Empty ? "emptyFields" :
				        usernameValue == string.Empty ? "emptyUsername" : "emptyPassword");
		        }
				UserController userController = new UserController();
				User user=	userController.get(x => x.email == usernameValue & x.password == passwordValue).Count>0 ?
					userController.get(x => x.email == usernameValue & x.password == passwordValue)[0] : null;
				
				if (user == null)
				{
					throw new Exception("Unoath");
				}

				Program.logged = true;
				this.Hide();
				dashboard =new Dashboard(user);
				dashboard.Show();

	        }
	        catch (Exception exception)
	        {
		        DisplayError(exception);
	        }
		}

		private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

		private void DisplayError(Exception error)
		{
			switch (error.Message)
			{
				case "emptyFields":
					MessageBox.Show("Please fill the empty fields and try to sign in again", "Empty Fields",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
					break;
				case "emptyUsername":
					MessageBox.Show("Please fill your username field in and try to sign in again", "Empty Username",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
					break;
				case "emptyPassword":
					MessageBox.Show("Please fill your password in and try to sign in again", "Empty Password",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
					break;
				case "Unoath":
					MessageBox.Show("Wrong email or password", "Unauthorized login",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
					break;
				default:
					break;

			}
		}
    }
}
