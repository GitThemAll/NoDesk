using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EASendMail;

namespace NoDesk
{
    class MailerController
    {
        private string emailAddress { get; set; }
        public MailerController(string emailAddress)
        {
            this.emailAddress = emailAddress;
        }
        public void sendMail(string emailAddress, Incident incident)
        {
            SmtpMail oMail = new SmtpMail("TryIt");
            oMail.From = "627650@student.inholland.nl";
            oMail.To = emailAddress;
            oMail.Subject = incident.subject;
            oMail.TextBody = String.Format("Dear {0}, you have recently filed an incident. Here is your incident number {1} with the following subject {2} and summary {3}",incident.user,incident.id,incident.subject,incident.summary);
            SmtpServer oServer = new SmtpServer("smtp.gmail.com");
            oServer.User = "projectnosql@gmail.com";
            oServer.Password = "projectnosql123";
            oServer.ConnectType = SmtpConnectType.ConnectTryTLS;
            oServer.Port = 587;
            SmtpClient oStmp = new SmtpClient();
            oStmp.SendMail(oServer, oMail);
        }
    }
}
