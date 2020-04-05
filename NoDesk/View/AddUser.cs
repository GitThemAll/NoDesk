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

namespace NoDesk.View
{
    public partial class AddUser : Form
    {
        UserManagement userManagement;

        public AddUser(UserManagement userManagement)
        {
            InitializeComponent();
            this.userManagement = userManagement;
            lblpassword.Hide();
            txtpassword.Hide();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            UserController userController = new UserController();
            User user = null;

            if (txtpassword.Text != "" || rbYes.Checked)
            {
                user = new User(txtfirstname.Text, txtlastname.Text, txtemail.Text, txtpassword.Text);
            }
            else
            {
                user = new User(txtfirstname.Text, txtlastname.Text, txtemail.Text);

            }
            userController.insert(user);
            userManagement.RefreshGV();
            userManagement.addUserForm = null;
            this.Close();
        }

        private void rbYes_CheckedChanged(object sender, EventArgs e)
        {
            lblpassword.Show();
            txtpassword.Show();
        }

        private void rbNo_CheckedChanged(object sender, EventArgs e)
        {
            lblpassword.Hide();
            txtpassword.Hide();
        }
    }
}
