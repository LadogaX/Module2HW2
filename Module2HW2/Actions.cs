using System;
using Module2HW2.Models;
using Module2HW2.Services;
using Module2HW2.Provides;

namespace Module2HW2
{
    public class Actions
    {
        private DeviceService _deviceService;
        private CartServices _cartService;
        private OrderService _orderService;

        // private Device[] _catalogDevices;
        public Actions(User user, ConfigService configService)
        {
            _deviceService = new DeviceService(configService.GetCoefficientConfig());
            _cartService = new CartServices(Cart.Instance, _deviceService, configService.GetCartConfig());
            _orderService = new OrderService(user, _cartService);
        }

        public void GetListDevices()
        {
            _deviceService.GetAllDevices();
            _deviceService.DisplayLoadedDevices();
        }

        public void AddIntoCart(int id_device)
        {
            _cartService.Add(id_device);
        }

        public void Checkout()
        {
            _orderService.Checkout();
        }

        public void DisplayCart()
        {
            Console.WriteLine();
            Console.WriteLine("CART CONTENT: ");
            _cartService.DisplayCart();
        }
    }
}
