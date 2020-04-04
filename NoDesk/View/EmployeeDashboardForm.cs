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
	public partial class EmployeeDashboardForm : Form
	{
		IncidentController incidentController= new IncidentController();
		private User currentUser;

		public EmployeeDashboardForm()
		{
			InitializeComponent();
		}

		public EmployeeDashboardForm(User user)
		{
			InitializeComponent();
			this.currentUser = user;
			this.Text = (string.Format("{0} {1} dashboard", currentUser.firstname, currentUser.lastname));
		}

		private void EmployeeDashboardForm_Load(object sender, EventArgs e)
		{
			addAll();
		}
		private void addAll()
		{
			List<Incident> incidents = incidentController.get(x=>x.assignedEmployee==this.currentUser);

			foreach (Incident incident in incidents)
			{
				GVspecificEmployeeIncident.Rows.Add(incident.id, incident.user, incident.subject, incident.date, incident.status, incident.summary, incident.assignedEmployee, incident.dueDate);
			}
		}
		public void RefreshGV()
		{
			GVspecificEmployeeIncident.Rows.Clear();
			addAll();
		}

		private void GVIncident_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
