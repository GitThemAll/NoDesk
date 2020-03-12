using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoDesk
{
	interface IController
	{
		List<BaseModel> get(string searchExpression);
		List<BaseModel> getAll();
		void insert(List<BaseModel> documents);


	}
}
