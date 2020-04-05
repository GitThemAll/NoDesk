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
        Dashboard dashboard;
        UserController userController = new UserController();
        internal AddUser addUserForm { get; set; }
        IncidentManagement incidentMangement;

        public UserManagement(User user, Dashboard dashboard)
        {
            InitializeComponent();
            this.user = user;
            this.dashboard = dashboard;
        }
     

        private void dashboardBTN_Click(object sender, EventArgs e)
        {
            dashboard.Show();
            this.Hide();
        }

        private void UserManagement_Load(object sender, EventArgs e)
        {
            AddAll();
        }
        private void AddAll()
        {
            List<User> users = userController.getAll();

            foreach (User user in users)
            {
                GVUser.Rows.Add(user.id, user.email, user.firstname, user.lastname);
            }
        }

        private void searchtxt_TextChanged(object sender, EventArgs e)
        {
            GVUser.Rows.Clear();
            string search = searchtxt.Text;
            List<User> users = userController.get(x => x.email == search);
            foreach (User user in users)
            {
                GVUser.Rows.Add(user.id, user.email, user.firstname, user.lastname);

            }
            if (searchtxt.Text == "")
            {
                AddAll();
            }
        }

        private void btnadduser_Click(object sender, EventArgs e)
        {
	        if (this.addUserForm == null)
	        {
		        this.addUserForm = new AddUser(this);
		        addUserForm.Show();
            }
            this.addUserForm.BringToFront();     
        }
        public void RefreshGV()
        {
            GVUser.Rows.Clear();
            AddAll();
        }

        private void incidentBTN_Click(object sender, EventArgs e)
        {
            if (this.incidentMangement == null)
            {
                incidentMangement = new IncidentManagement(this.user, this.dashboard);
            }

            incidentMangement.Show();
            this.Hide();
        }

        private void UserManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    
    }
}
