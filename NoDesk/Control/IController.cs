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
		List<BaseModel> getMany();
		void insert(BaseModel model);
		void insertMany(List<BaseModel> models);


	}
}
