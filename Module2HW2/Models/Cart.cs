using System;
using Module2HW2.Models;
using Module2HW2.Services;
using Module2HW2.Provides;

namespace Module2HW2.Models
{
    public class Cart
    {
        private static readonly Cart _instance = new Cart();

        static Cart()
        {
        }

        private Cart()
        {
            Devices = new Device[Capacity];
        }

        public static Cart Instance => _instance;
        public int Capacity { get; private set; }

        public Device[] Devices { get; set; }
    }
}
