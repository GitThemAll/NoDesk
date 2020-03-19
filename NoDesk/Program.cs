 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoDesk
{
	static class Program
	{
		public static bool logged = false;
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			bool something = DateTime.Now.Date > DateTime.Now.Date.AddDays(-1);
			//IncidentController incon = new IncidentController();
			//List<Incident> incidents = new List<Incident>();
			//Incident incident = new Incident
			//{
			//	subject = "pc6 not working",
			//	user = "Thijs",
			//	date = DateTime.Now.Date,
			//	status = IncidentStatus.NotSolved.ToString(),
			//	summary = "No summery",
			//	assignedEmployee = "Not yet Assigned",
			//	dueDate = DateTime.Now.Date.AddDays(+1)
			//};
			//Incident incidentTwo = new Incident
			//{
			//	subject = "pc5 not working",
			//	user = "Marco",
			//	date = DateTime.Now.Date,
			//	status = IncidentStatus.NotSolved.ToString(),
			//	summary = "No summery",
			//	assignedEmployee = "Not yet Assigned",
			//	dueDate = DateTime.Now.Date.AddDays(+4)
			//};
			//incidents.Add(incident);
			//incidents.Add(incidentTwo);
			//incon.insert(incidents);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new NoDesk());
		}
	}
}
