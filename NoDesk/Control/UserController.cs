using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;


namespace NoDesk
{
	class UserController : IController
	{
		UserQuery query = new UserQuery();
				
		public BaseModel get()
		{
			throw new NotImplementedException();
		}
		public User getLogin(string email, string password)
		{
			return query.GetLogin(email, password);

		}

		public List<BaseModel> getMany()
		{
			throw new NotImplementedException();
		}

		public void insert(BaseModel model)
		{
			throw new NotImplementedException();
		}

		public void insertMany(List<BaseModel> models)
		{
			throw new NotImplementedException();
		}
	}
}
