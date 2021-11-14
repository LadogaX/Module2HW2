using System;
using Module2HW2.Models;
using Module2HW2.Services;
using Module2HW2.Provides;

namespace Module2HW2.Services
{
    internal class OrderService
    {
        private CartServices _cartService;
        private Orders _orders;
        private User _user;
        public OrderService(User user, CartServices cartService)
        {
            _cartService = cartService;
            _user = user;
            _orders = Orders.Instance;
        }

        internal void Checkout()
        {
            Device[] orderDevices = _cartService.GetChoiceDevice();
            _orders.Add(orderDevices);
            string message = _orders.Checkout();
            NotificationsService notificationsService = new NotificationsService(_user, message);
            notificationsService.SendSms();
            notificationsService.SendEMail();
            _cartService.Clear();
        }
    }
}