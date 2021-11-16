using System;
using Module2HW2.Models;
using Module2HW2.Services;
using Module2HW2.Provides;

namespace Module2HW2.Services
{
    internal class OrderService
    {
        private CartServices _cartService;
        private Device[] _dataOrders;
        private User _user;
        private int _capacity = 10;

        public OrderService(User user, CartServices cartService)
        {
            _cartService = cartService;
            _user = user;
            Orders orders = new Orders(_capacity);
            _dataOrders = orders.DataOrders;
            CountDevice = 0;
        }

        public int CountDevice { get; set; }
        public void Checkout()
        {
            Device[] orderDevices = _cartService.GetChoiceDevice();
            Add(orderDevices);

            string message = GetTextCheckout();

            NotificationsService notificationsService = new NotificationsService(_user, message);

            notificationsService.NotificationEMailService = new NotificationEMailService();
            notificationsService.NotificationSmsService = new NotificationSmsService();

            notificationsService.Notify();

            _cartService.Clear();
        }

        public void SetCapacity(int capacityCart)
        {
            Array.Resize(ref _dataOrders, capacityCart);
        }

        public void Add(Device device)
        {
            for (var i = CountDevice; i < _dataOrders.Length; i++)
            {
                if (_dataOrders[i] == null)
                {
                    _dataOrders[i] = device;
                    CountDevice++;
                    break;
                }
                else
                {
                    SetCapacity(_capacity);
                }
            }
        }

        public void Add(Device[] devices)
        {
            foreach (Device device in devices)
            {
                Add(device);
            }
        }

        public string GetTextCheckout()
        {
            Random random = new Random();
            return $"generated order № {random.Next(10000)} time: {DateTime.UtcNow}";
        }
    }
}