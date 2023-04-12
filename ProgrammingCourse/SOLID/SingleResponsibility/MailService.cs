using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCourse.SOLID.SingleResponsibility
{
    internal class MailService
    {
        public void SendMail(string from, string to, string subject, string body)
        {
            // sending mail implementation
            Console.WriteLine("Sending mail");
        }
    }
}
