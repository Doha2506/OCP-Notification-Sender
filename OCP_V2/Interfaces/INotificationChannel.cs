using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_V2.Interfaces
{
    internal interface INotificationChannel
    {
        public void Send(string message);
    }
}
