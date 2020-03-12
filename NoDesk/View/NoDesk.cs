using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoDesk
{
	public partial class NoDesk : Form
	{
		UserController userController = new UserController();
		User currentuser;
		public NoDesk()
		{
			InitializeComponent();
			
		}

		private void label1_Click(object sender, EventArgs e)
		{
			//label1.Text=	user.email;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (true)
			{
				currentuser = userController.getLogin("prinsalvino@gmail.com", "Yes123");
				label1.Text = currentuser.name + currentuser.email;
			}
			else
			{
				label1.Text = "Wrong Credentials";
			}
			
		}

		private void NoDesk_Load(object sender, EventArgs e)
		{
			//User user = UserController.getLogin(label1.Text.ToString());
		}
	}
}
