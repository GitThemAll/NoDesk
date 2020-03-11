using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoDesk
{
	public class Incident : BaseModel
	{
		public string Subject { get; set; }
		public string User { get; set; }
		public string Date { get; set; }
		public string Status { get; set; }
		public string summary { get; set; }
		public string assignedEmployee { get; set; }
		public string dueDate { get; set; }
	}
}


