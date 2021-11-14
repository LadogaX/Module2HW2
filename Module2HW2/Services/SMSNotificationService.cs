using System;

namespace Module2HW2.Services
{
    internal class SMSNotificationService
    {
        internal static void Send(string phone, string message)
        {
            Console.WriteLine($"SMS {phone} notification {message}");
            Console.WriteLine();
        }
    }
}