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
           
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            UserController userController = new UserController();
            User user = new User(txtfirstname.Text, txtlastname.Text, txtemail.Text, txtpassword.Text);

            if (rbAdmin.Checked)
            {
                user.type = UserType.Admin;
                userController.insert(user);

            }
            else if (rbEmployee.Checked)
            {
                user.type = UserType.Employee;
                userController.insert(user);

            }
            else
            {
                string text = "Please check employee type";
                MessageBox.Show(text);
            }
            
            userManagement.RefreshGV();
            userManagement.addUserForm = null;
            this.Close();
        }

        private void rbYes_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void rbNo_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }
}
