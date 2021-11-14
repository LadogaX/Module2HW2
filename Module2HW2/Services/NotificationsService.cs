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

        public void SendSms()
        {
            SMSNotificationService.Send(_user.Phone, _message);
        }

        public void SendEMail()
        {
            EMailNotificatiomService.Send(_user.Email, _message);
        }
    }
}
