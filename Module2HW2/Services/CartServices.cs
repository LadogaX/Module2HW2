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
        private Device[] _cartContens;
        public CartServices(Cart cart, DeviceService deviceService, CartConfig config)
        {
            _cart = cart;
            _cartContens = _cart.Devices;
            SetCapacity(config.Capacity);
            _deviceService = deviceService;
        }

        public int CountDevice { get; private set; }
        public int Capacity { get; private set; }
        public void Add(int id_device)
        {
            Device device = GetDevice(id_device);
            if (device != null)
            {
                Add(device);
            }
            else
            {
                Console.WriteLine($"ID_DEVICE={id_device} is not found");
            }
        }

        public void Add(Device device)
        {
            for (var i = CountDevice; i < _cartContens.Length; i++)
            {
                if (_cartContens[i] == null)
                {
                    _cartContens[i] = device;
                    CountDevice++;
                    break;
                }
                else
                {
                    SetCapacity(10);
                }
            }
        }

        public void DisplayCart()
        {
            _deviceService.DisplayDevices(GetCartContens());
        }

        public void SetCapacity(int capacityCart)
        {
            Capacity = capacityCart;
            Array.Resize(ref _cartContens, capacityCart);
        }

        public void Clear()
        {
            Array.Clear(_cartContens, 0, _cartContens.Length - 1);
        }

        public Device[] GetCartContens()
        {
            return _cartContens;
        }

        public Device[] GetChoiceDevice()
        {
            Device[] choiceDevices = new Device[CountDevice];
            Array.Copy(_cartContens, choiceDevices, CountDevice);
            return choiceDevices;
        }

        private Device GetDevice(int id_device)
        {
            Device findingDevice = null;
            foreach (Device device in _deviceService.ListDevice)
            {
                if (device.Id == id_device)
                {
                    findingDevice = device;
                    break;
                }
            }

            return findingDevice;
        }
    }
}
