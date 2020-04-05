using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoDesk.View;

namespace NoDesk
{
    public partial class NoDesk : Form
    {
        private Dashboard dashboard;
        private EmployeeDashboardForm employeeDashboardForm;
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
                List<User> userlist = userController.get(x => x.email == usernameValue & x.password == passwordValue);
                User user = userlist.Count > 0 ? userlist[0] : null;

                if (user == null)
                {
                    throw new Exception("Unoath");
                }


                dashboard = new Dashboard(user);
                dashboard.Show();



                Program.logged = true;
                this.Hide();


            }
            catch (Exception exception)
            {
                ErrorHandler.DisplayError(exception);
            }
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}