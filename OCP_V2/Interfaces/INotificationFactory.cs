using OCP_V2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_V2.Interfaces
{
    internal interface INotificationFactory
    {
        void Register(NotificationChannel channel, Func<INotificationChannel> factory);

        void Send(NotificationChannel channel, string message);
    }
}
