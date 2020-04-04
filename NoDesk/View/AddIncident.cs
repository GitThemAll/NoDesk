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
        private User assignedEmployee;

        public AddIncident(IncidentManagement incidentManagement, IncidentController incidentController)
        {
            InitializeComponent();
            this.incidentmanagment = incidentManagement;
            this.incidentController = incidentController;
            this.btn_editIncident.Enabled = false;
            this.btn_editIncident.Hide();
        }
        public AddIncident(IncidentManagement incidentManagement, IncidentController incidentController, Dictionary<string, string> incidentDictionary)
        {
            InitializeComponent();
            this.incidentManagement = incidentManagement;
            this.incidentDictionary = incidentDictionary;
            this.Text = "Edit incident";
            this.btn_addIncident.Enabled=false;
            this.btn_addIncident.Hide();
        }
        

        private void btn_addIncident_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(inpt_incident_dueDate.Text)|| string.IsNullOrEmpty(inpt_incident_summary.Text)||
                string.IsNullOrEmpty(inpt_incident_subject.Text)|| string.IsNullOrEmpty(inpt_incident_user.Text) || string.IsNullOrEmpty(inpt_incident_email.Text))
            {
                ErrorHandler.DisplayError(new Exception("emptyFields"));
                return;
            }
            DateTime due = DateTime.Parse(inpt_incident_dueDate.Text);
            this.incidentController.insert(new Incident(inpt_incident_subject.Text, inpt_incident_user.Text, inpt_incident_summary.Text, due, this.assignedEmployee));
            this.incidentmanagment.BringToFront();
            this.incidentmanagment.RefreshGV();
            MailerController mailer = new MailerController(inpt_incident_email.Text);
            mailer.sendMail(inpt_incident_email.Text,new Incident(inpt_incident_subject.Text, inpt_incident_user.Text, inpt_incident_summary.Text, due, this.assignedEmployee));
            this.Close();
        }

        private void AddIncident_Load(object sender, EventArgs e)
        {
	        inpt_incident_assignedEmployee.Items.Insert(0, "Not assigned");

	        int count = 1;
	        foreach (var item in this.userController.employees)
	        {
		        inpt_incident_assignedEmployee.Items.Insert(count, item);
		        count++;
	        }
            if (this.incidentDictionary!=null)
            {
	            inpt_incident_user.Text = incidentDictionary["user"];
                inpt_incident_summary.Text = incidentDictionary["summary"];
                inpt_incident_subject.Text = incidentDictionary["subject"];
                inpt_incident_dueDate.Value = DateTime.Parse(incidentDictionary["dueDate"]);
                if (string.Empty==(this.incidentDictionary["assignedEmployee"]))
                {
	                inpt_incident_assignedEmployee.SelectedItem = 0;
	                inpt_incident_assignedEmployee.SelectedIndex = 0;
                }
                else
                {
	                inpt_incident_assignedEmployee.SelectedItem =
		                inpt_incident_assignedEmployee.FindString(this.incidentDictionary["assignedEmployee"]);
                    inpt_incident_assignedEmployee.SelectedIndex = inpt_incident_assignedEmployee.FindString(this.incidentDictionary["assignedEmployee"]);
                }

            }
            
	    }

        private void inpt_incident_assignedEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
	        if (inpt_incident_assignedEmployee.SelectedItem == "Not assigned")
	        {
		        return;
	        }
	        this.assignedEmployee = (User)inpt_incident_assignedEmployee.SelectedItem;
        }

        private void btn_editIncident_Click(object sender, EventArgs e)
        {
        }
    }
}
