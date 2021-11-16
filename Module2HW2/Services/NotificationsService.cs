using System;
using Module2HW2.Models;
using Module2HW2.Services;

namespace Module2HW2.Services
{
    public class NotificationsService
    {
        private User _user;
        private string _message;
        public NotificationsService(User user, string message)
        {
            _user = user;
            _message = message;
        }

        public NotificationSmsService NotificationSmsService { get; set; }

        public NotificationEMailService NotificationEMailService { get; set; }

        public void Notify()
        {
            if (_user.SendSms)
            {
                NotificationSmsService.Send(_user.Phone, _message);
            }

            if (_user.SendEMail)
            {
                NotificationEMailService.Send(_user.Email, _message);
            }
        }
    }
}
