using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace NoDesk
{
	public static class Settings
	{
		public static string username { get; set; }
		public static string password { get; set; }
		public static string clusterAddress { get; set; }

		static Settings()
		{
			using (StreamReader reader = new StreamReader("D:\\localGithub\\NoDesk\\NoDesk\\DAL\\Config\\Settings.json"))
			{
				string jsonSettingsString = reader.ReadToEnd();
				JObject jsonSettings = JObject.Parse(jsonSettingsString);
				username = jsonSettings.Value<string>("username");
				password = jsonSettings.Value<string>("password");
				clusterAddress = jsonSettings.Value<string>("clusterAddress");
			}
			

			
		}
	}
}