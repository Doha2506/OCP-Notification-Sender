using OCP_V2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_V2.Services
{
    internal class SMS_Service : INotificationChannel
    {
        public void Send(string message)
        {
           Console.WriteLine("Sending SMS : " + message);
        }
    }
}
