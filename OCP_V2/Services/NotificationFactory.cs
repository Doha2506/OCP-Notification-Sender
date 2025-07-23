using OCP_V2.Interfaces;
using OCP_V2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_V2.Services
{
    internal class NotificationFactory : INotificationFactory
    {
        private readonly Dictionary<NotificationChannel, Func<INotificationChannel>> _channels;

        public NotificationFactory()
        {
            _channels = new Dictionary<NotificationChannel, Func<INotificationChannel>>();

            RegisterDefaultChannels();
        }

        private void RegisterDefaultChannels()
        {
            _channels.Add(NotificationChannel.Email, () => new EmailService());
            _channels.Add(NotificationChannel.SMS, () => new SMS_Service());
        }


        public void Register(NotificationChannel channel, Func<INotificationChannel> factory)
        {
            _channels.Add(channel, factory);   
        }

        public void Send(NotificationChannel channel, string message)
        {
            if (!_channels.ContainsKey(channel)) 
            {
                throw new ArgumentException("No channel found for " + channel);
            }
            _channels[channel]().Send(message);
        }
    }
}
