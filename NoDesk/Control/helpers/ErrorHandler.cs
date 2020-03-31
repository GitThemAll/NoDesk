using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Logging;

namespace NoDesk
{
	static public class ErrorHandler
	{
		public static void DisplayError(Exception error)
		{
			Trace.Listeners.Add(new TextWriterTraceListener("log\\logfile.log"));
			Trace.AutoFlush = true;

			switch (error.Message)
			{
				case "emptyFields":
					MessageBox.Show("Please fill the empty fields and try to sign in again", "Empty Fields",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
					break;
				case "emptyUsername":
					MessageBox.Show("Please fill your username field in and try to sign in again", "Empty Username",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
					break;
				case "emptyPassword":
					MessageBox.Show("Please fill your password in and try to sign in again", "Empty Password",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
					break;
				case "Unoath":
					MessageBox.Show("Wrong email or password", "Unauthorized login",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
					Trace.TraceInformation("---------An unknown error has occured-------------");
					Trace.TraceError(error.StackTrace);
					Trace.TraceWarning(error.Message);
					break;
				default:
					MessageBox.Show("Something went wrong", "Error", 
						MessageBoxButtons.OK, MessageBoxIcon.Error);
					Trace.TraceInformation("---------An unknown error has occured---------");
					Trace.TraceError(error.StackTrace+error.Message);
					Trace.TraceWarning(error.Message);
					break;

			}
		}
	}
}
