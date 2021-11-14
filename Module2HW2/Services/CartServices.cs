using System;
using Module2HW2.Models;
using Module2HW2.Configs;
using Module2HW2.Provides;

namespace Module2HW2.Services
{
   public class CartServices
    {
        private Cart _cart;
        private DeviceService _deviceService;
        public CartServices(Cart cart, DeviceService deviceService, CartConfig config)
        {
            _cart = cart;
            _cart.SetCapacity(config.Capacity);
            _deviceService = deviceService;
        }

        public void Add(int id_device)
        {
            Device device = GetDevice(id_device);
            if (device != null)
            {
                _cart.Add(device);
            }
            else
            {
                Console.WriteLine($"ID_DEVICE={id_device} is not found");
            }
        }

        public void Clear()
        {
            _cart.Clear();
        }

        public void DisplayCart()
        {
            _deviceService.DisplayDevices(_cart.GetCartContens());
        }

        public Device[] GetChoiceDevice()
        {
            return _cart.GetChoiceDevice();
        }

        private Device GetDevice(int id_device)
        {
            Device device = null;
            foreach (Device d in _deviceService.ListDevice)
            {
                if (d.Id == id_device)
                {
                    device = d;
                    break;
                }
            }

            return device;
        }
    }
}
