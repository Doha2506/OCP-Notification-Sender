using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OCP_V2.Interfaces;
using OCP_V2.Models;
using OCP_V2.Services;

var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddTransient<INotificationFactory, NotificationFactory>();
    })
    .Build();


var notificationFactory = host.Services.GetRequiredService<INotificationFactory>();

notificationFactory.Send(NotificationChannel.Email , " Hi Doha");

notificationFactory.Send(NotificationChannel.SMS , " Hi Ali");

// register new channel
notificationFactory.Register(NotificationChannel.Toaster, () => new ToasterService());

// use new channel
notificationFactory.Send(NotificationChannel.Toaster, " Hi Mostafa");


