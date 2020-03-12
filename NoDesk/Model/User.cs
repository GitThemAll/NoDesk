using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoDesk
{
	class User : BaseModel
	{
		public string firstname { get; set; }
		public string lastname { get; set; }
		public string email { get; set; }
		public string password { get; set; }

	}
}
