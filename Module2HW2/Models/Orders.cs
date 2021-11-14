using System;

namespace Module2HW2.Models
{
    public class Orders
    {
        private readonly int _capacity = 10;
        private static readonly Orders _instance = new Orders();
        private Device[] _orders;
        static Orders()
        {
        }

        private Orders()
        {
            _orders = new Device[10];
            CountDevice = 0;
    }

        public static Orders Instance => _instance;
        public int CountDevice { get; private set; }
        public void SetCapacity(int capacityCart)
        {
            Array.Resize(ref _orders, capacityCart);
        }

        public void Add(Device device)
        {
            for (var i = CountDevice; i < _orders.Length; i++)
            {
                if (_orders[i] == null)
                {
                    _orders[i] = device;
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

        public string Checkout()
        {
            Random random = new Random();
            return $"generated order № {random.Next(10000)} time: {DateTime.UtcNow}";
        }
    }
}
