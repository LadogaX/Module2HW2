using System;

namespace Module2HW2.Services
{
    public class NotificationEMailService
    {
        public void Send(string email, string message)
        {
            Console.WriteLine($"EMail {email} notification {message}");
            Console.WriteLine();
        }
    }
}