using System;
using Module2HW2.Models;
using Module2HW2.Services;
using Module2HW2.Provides;

namespace Module2HW2.Models
{
    public class Cart
    {
        private static readonly Cart _instance = new Cart();
        private Device[] _device;

        static Cart()
        {
        }

        private Cart()
        {
            _device = new Device[Capacity];
            CountDevice = 0;
        }

        public static Cart Instance => _instance;

        public int Capacity { get; private set; }
        public int CountDevice { get; private set; }

        public void Add(Device device)
        {
            for (var i = CountDevice; i < _device.Length; i++)
            {
                if (_device[i] == null)
                {
                    _device[i] = device;
                    CountDevice++;
                    break;
                }
                else
                {
                    SetCapacity(10);
                }
            }
        }

        public void SetCapacity(int capacityCart)
        {
            Capacity = capacityCart;
            Array.Resize(ref _device, Capacity);
        }

        public void Clear()
        {
            Array.Clear(_device, 0, _device.Length - 1);
        }

        public Device[] GetCartContens()
        {
            return _device;
        }

        public Device[] GetChoiceDevice()
        {
            Device[] choiceDevices = new Device[CountDevice];
            Array.Copy(_device, choiceDevices, CountDevice);
            return choiceDevices;
        }
    }
}
