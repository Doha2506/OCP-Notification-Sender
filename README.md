✅ Task: Notification Sender (OCP Challenge)
📘 Problem Statement:
You are building a NotificationService that sends messages to users through different channels (e.g., Email, SMS, Push notification).

The service should follow OCP, meaning:

The existing logic should not be modified when a new notification channel is added.

You should be able to register new channels dynamically, similar to how you did in DiscountFactory.

🔧 Requirements:
Define an interface like INotificationChannel with a method:

csharp
Copy
Edit
void Send(string message);
Implement a few notification channels, e.g.:

EmailNotification

SmsNotification

Create a class NotificationService:

Holds a dictionary of registered channels (e.g., "Email", "SMS").

Provides:

Send(string channel, string message) → Sends message via the specified channel.

Register(string channelName, Func<INotificationChannel> factory) → Adds a new channel without modifying code.

✅ Add at least one new channel (e.g., PushNotification) using register method only.

🧪 Example Usage:

var service = new NotificationService();

// Register default channels
service.Register("Email", () => new EmailNotification());
service.Register("SMS", () => new SmsNotification());

// Register a new one dynamically
service.Register("Push", () => new PushNotification());

// Send via different channels
service.Send("Email", "Welcome!");
service.Send("Push", "You have a new message.");

🎯 Goal:
Do not use switch, if-else, or hardcoded mapping.

Avoid modifying existing classes for new types.

Follow OCP: Open for extension, closed for modification.
