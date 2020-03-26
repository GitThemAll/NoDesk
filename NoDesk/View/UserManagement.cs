using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Microsoft.CodeAnalysis.CSharp.Syntax;


namespace NoDesk.View
{
    public partial class UserManagement : Form
    {
        User user;
        public UserManagement()
        {
            InitializeComponent();
        }

        private void dashboardBTN_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(user);
            dashboard.Show();
        }

        private void UserManagement_Load(object sender, EventArgs e)
        {
            UserController userController = new UserController();
            List<User> users = userController.getAll();
            foreach (User user in users)
            {
                GVUser.Rows.Add(user.id);
                GVUser.Rows.Add(user.email);
                GVUser.Rows.Add(user.firstname);
                GVUser.Rows.Add(user.lastname);
            }


        }
    }
}
