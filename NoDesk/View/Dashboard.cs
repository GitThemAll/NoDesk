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
using NoDesk.View;

namespace NoDesk
{
    public partial class Dashboard : Form
    {
		IncidentController incidentController = new IncidentController();
	    private List<Incident> incidents;
	    private List<Incident> solvedIncidents;
	    private List<Incident> notSolvedIncidents;
	    private List<Incident> pastIncidents;
		User user;
		IncidentManagement incidentManagement;
		UserManagement userManagement;

		public Dashboard(User user)
	    {
		    InitializeComponent();
			this.user = user;
			this.Text = string.Format("{0} {1} Dashboard", user.firstname, user.lastname);
		    this.incidents = incidentController.getAll();
		    this.pastIncidents = incidentController.pastIncidents;
		    this.notSolvedIncidents = incidentController.notSolvedIncidents;
		    this.solvedIncidents = incidentController.solvedIncidents;

		   

		}
		
		private void usermanageBTN_Click(object sender, EventArgs e)
		{
			if (this.userManagement == null)
			{
				userManagement = new UserManagement(this.user, this);
			}

			userManagement.Show();
			this.Hide();
		}

		private void Dashboard_Load(object sender, EventArgs e)
		{
			if (this.user.type == UserType.Admin)
			{
				loadAll();
			}
			else if (this.user.type == UserType.Employee)
			{
				
				loadEmployee();
			}
				
			
		}
		private void loadEmployee()
		{
			List<Incident> employeeIncidents = this.incidentController.get(x => x.assignedEmployee == this.user);
			int employeeIncidentsNumber = employeeIncidents.Count == 0 ? 1 : employeeIncidents.Count;
			int employeeSolvedIncidents = employeeIncidents.FindAll(x => x.status == IncidentStatus.Solved).Count;
			int employeeNotsolvedIncidents= employeeIncidents.FindAll(x => x.status == IncidentStatus.NotSolved).Count;
			int employeePastIncidents=employeeIncidents.FindAll(x => x.dueDate < DateTime.Now).Count;
			UnResolvedIncidentsProgressBar.Text = string.Format("{0}/{1}", employeeNotsolvedIncidents, employeeIncidents.Count);
			ResolvedIncidentsProgressBar.Text = string.Format("{0}/{1}", employeeSolvedIncidents, employeeIncidents.Count);
			PastIncidentsProgressBar.Text = string.Format("{0}/{1}", employeePastIncidents, employeeIncidents.Count);
			UnResolvedIncidentsProgressBar.Value = (employeeNotsolvedIncidents*100)/ employeeIncidentsNumber;
			PastIncidentsProgressBar.Value = (employeePastIncidents * 100) / employeeIncidentsNumber;
			ResolvedIncidentsProgressBar.Value = (employeeSolvedIncidents * 100) / employeeIncidentsNumber;

			usermanageBTN.Enabled = false;
			usermanageBTN.Hide();
		}
		private void loadAll ()
		{
			UnResolvedIncidentsProgressBar.Text = string.Format("{0}/{1}", notSolvedIncidents.Count, incidents.Count);
			UnResolvedIncidentsProgressBar.Value = incidentController.notSolvedIncidentsPercentage;

			PastIncidentsProgressBar.Text = string.Format("{0}/{1}", pastIncidents.Count, incidents.Count);
			PastIncidentsProgressBar.Value = incidentController.pastIncidentsPercentage;

			ResolvedIncidentsProgressBar.Text = string.Format("{0}/{1}", solvedIncidents.Count, incidents.Count);
			ResolvedIncidentsProgressBar.Value = incidentController.solvedIncidentsPercentage;
		}
		private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		private void incidentBTN_Click(object sender, EventArgs e)
		{
			if (this.incidentManagement == null)
			{
				incidentManagement = new IncidentManagement(this.user, this);
			}
			incidentManagement.Show();
			this.Hide();
		}
	}
}
