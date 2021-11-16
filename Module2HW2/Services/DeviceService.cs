using System;
using Module2HW2.Models;
using Module2HW2.Configs;
using Module2HW2.Provides;

namespace Module2HW2.Services
{
   public class DeviceService
    {
        private DeviceProvider _deviceProvider;
        private ConfigService _configService;
        public DeviceService(ConfigService configService)
        {
            _deviceProvider = new DeviceProvider(DataBase.Instance);
            _configService = configService;
        }

        public Device[] ListDevice { get; set; }

        public Device[] GetAllDevices()
        {
            ListDevice = _deviceProvider.GetAllDevices();
            CurrencyCoefficient coefficient = _configService.GetCoefficient();
            for (var i = 0; i < ListDevice.Length; i++)
            {
                ListDevice[i].Currency = coefficient.Currency;
                ListDevice[i].Price *= coefficient.Value;
            }

            return ListDevice;
        }

        public void DisplayDevices(Device[] devices)
        {
            for (var i = 0; i < devices.Length; i++)
            {
                if (devices[i] != null)
                {
                  Console.WriteLine($"ID: {devices[i].Id,-4} Name: {devices[i].Name,-20} Price: {devices[i].Price,12:F2} {devices[i].Currency,-3}");
                }
            }

            Console.WriteLine();
        }
    }
}
