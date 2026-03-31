using System;
using Personal_Finance_Tracker.Interfaces;

namespace Personal_Finance_Tracker.Adapters
{
    public class ConsoleNotificationAdapter : INotificationService
    {
        public void SendNotification(string message)
        {
            Console.WriteLine("⚠️ ALERT: " + message);
        }
    }
}