using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoDesk.View
{
    public partial class AddIncident : Form
    {
        IncidentManagement incidentmanagment;
        IncidentController incidentController;
        UserController userController = new UserController();
        private IncidentManagement incidentManagement;
        private Dictionary<string, string> incidentDictionary;

        public AddIncident(IncidentManagement incidentManagement, IncidentController incidentController)
        {
            InitializeComponent();
            this.incidentmanagment = incidentManagement;
            this.incidentController = incidentController;
        }

        public AddIncident(IncidentManagement incidentManagement, IncidentController incidentController, Dictionary<string, string> incidentDictionary)
        {
            InitializeComponent();
            this.incidentManagement = incidentManagement;
            this.incidentDictionary = incidentDictionary;
        }

        private void btn_addIncident_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(inpt_incident_dueDate.Text)|| string.IsNullOrEmpty(inpt_incident_summary.Text)||
                string.IsNullOrEmpty(inpt_incident_subject.Text))
            {
                ErrorHandler.DisplayError(new Exception("emptyFields"));
                return;
            }
            DateTime due = DateTime.Parse(inpt_incident_dueDate.Text);
            this.incidentController.insert(new Incident(inpt_incident_subject.Text,inpt_incident_user.Text,inpt_incident_summary.Text,
                due));
            this.incidentmanagment.BringToFront();
            this.Close();
        }

        private void AddIncident_Load(object sender, EventArgs e)
        {
            if (this.incidentDictionary!=null)
            {
                inpt_incident_summary.Text = incidentDictionary["summary"];
                inpt_incident_subject.Text = incidentDictionary["subject"];
                inpt_incident_dueDate.Value = DateTime.Parse(incidentDictionary["dueDate"]);
            }
            inpt_incident_assignedEmployee.DataSource = this.userController.employees;
        }
    }
}
