using System;

namespace Module2HW2.Services
{
    public class NotificationSmsService
    {
        public void Send(string phone, string message)
        {
            Console.WriteLine($"SMS {phone} notification {message}");
            Console.WriteLine();
        }
    }
}