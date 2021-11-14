using System;

namespace Module2HW2.Services
{
    internal class EMailNotificatiomService
    {
        internal static void Send(string email, string message)
        {
            Console.WriteLine($"EMail {email} notification {message}");
            Console.WriteLine();
        }
    }
}