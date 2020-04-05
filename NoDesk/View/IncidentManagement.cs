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
using Windows.UI.Xaml.Controls;



namespace NoDesk.View
{
    public partial class IncidentManagement : Form
    {
	    private Incident selctedIncident { get; set; }
        User incidentUser;
        Dashboard dashboard;
        IncidentController incidentController = new IncidentController();
        UserManagement userManagement;
        Dictionary<string, string> incidentDictionary; 


        public IncidentManagement(User user, Dashboard dashboard, UserManagement userManagement)
        {
            InitializeComponent();
            this.incidentUser = user;
            this.dashboard = dashboard;
            this.userManagement = userManagement;
            
        }

        public IncidentManagement(User user, Dashboard dashboard)
        {
            InitializeComponent();
            this.incidentUser = user;
            this.dashboard = dashboard;
            
        }

        private void dashboardBTN_Click(object sender, EventArgs e)
        {
            dashboard.Show();
            this.Close();
        }

       
        private void AddAll()
        {
            List<Incident> incidents = incidentController.getAll();

            foreach (Incident incident in incidents)
            {
                GVIncident.Rows.Add(incident.id, incident.user, incident.subject, incident.date, incident.status, incident.summary, incident.assignedEmployee, incident.dueDate);
            }
        }
        public void RefreshGV()
        {
            GVIncident.Rows.Clear();
            AddAll();
        }

        private void usermanageBTN_Click(object sender, EventArgs e)
        {
            if (this.userManagement==null)
            {
                this.userManagement = new UserManagement(this.incidentUser, this.dashboard);
            }
            this.userManagement.Show();
            this.Close();
        }

        private void searchtxt_TextChanged(object sender, EventArgs e)
        {
            GVIncident.Rows.Clear();
            string search = searchtxt.Text;
            List<Incident> incidents = incidentController.get(x => x.id.ToString() == search);
            foreach (Incident incident in incidents)
            {
                GVIncident.Rows.Add(incident.id, incident.user, incident.subject, incident.date, incident.status, incident.summary, incident.assignedEmployee, incident.dueDate);

            }
            if (searchtxt.Text == "")
            {
                AddAll();
            }
        }

        private void IncidentManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void IncidentManagement_Load(object sender, EventArgs e)
        {
            AddAll();
        }

        private void btnAddIncident_Click(object sender, EventArgs e)
        {
            AddIncident addIncident = new AddIncident(this,this.incidentController);
            addIncident.ShowDialog();
        }

        private void editIncident_Click(object sender, EventArgs e)
        {
            AddIncident addIncident = new AddIncident(this,this.incidentController,this.selctedIncident);
            addIncident.ShowDialog();
        }

        private void GVIncident_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.selctedIncident= new Incident(GVIncident.SelectedRows[0].Cells[0].Value.ToString(),
            GVIncident.SelectedRows[0].Cells[2].Value.ToString(),
	            GVIncident.SelectedRows[0].Cells[1].Value.ToString(),
	            GVIncident.SelectedRows[0].Cells[5].Value.ToString(), 
	            DateTime.Parse(GVIncident.SelectedRows[0].Cells[7].Value.ToString()),
	            (User)GVIncident.SelectedRows[0].Cells[6].Value ,
                DateTime.Parse(GVIncident.SelectedRows[0].Cells[3].Value.ToString()),
                (IncidentStatus)Enum.Parse(typeof(IncidentStatus), GVIncident.SelectedRows[0].Cells[4].Value.ToString())

	            );
            btn_editIncident.Enabled= true;
        }

        
    }
}
