using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoDesk
{
	interface IController
	{
		BaseModel get();
		List<BaseModel> getMany(List<BaseModel> documents, SearchMethod searchMethod);
		List<BaseModel> getAll();
		void insert(List<BaseModel> documents);


	}
}
