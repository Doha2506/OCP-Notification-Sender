using OCP_V2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_V2.Services
{
    internal class EmailService : INotificationChannel
    {
        public void Send(string message)
        {
            Console.WriteLine("Sending Email with message : " + message);
        }
    }
}
