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
		public NoDesk()
		{
			InitializeComponent();
			
		}

        private void login_btn_Click(object sender, EventArgs e)
        {
            string email = (userName_txt.Text).Trim();
            string password = (password_txt.Text).Trim();

            if (!string.IsNullOrEmpty(email)|| !string.IsNullOrEmpty(password))
            {

            }
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            NoDesk.ActiveForm.Close();
        }
    }
}
