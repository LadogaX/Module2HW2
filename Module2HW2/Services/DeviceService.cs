using System;
using Module2HW2.Models;
using Module2HW2.Configs;
using Module2HW2.Provides;

namespace Module2HW2.Services
{
   public class DeviceService
    {
        private DeviceProvider _deviceProvider;
        private CoefficientConfig _coefficientConfig;
        public DeviceService(CoefficientConfig coefficientConfig)
        {
            _deviceProvider = new DeviceProvider(DataBase.Instance);
            _coefficientConfig = coefficientConfig;
        }

        public Device[] ListDevice { get; set; }

        public Device[] GetAllDevices()
        {
            ListDevice = _deviceProvider.GetAllDevices();
            double coefficient = _coefficientConfig.GetCoefficient();
            for (var i = 0; i < ListDevice.Length; i++)
            {
                ListDevice[i].Currency = _coefficientConfig.Currency;
                ListDevice[i].Price *= coefficient;
            }

            return ListDevice;
        }

        public void DisplayLoadedDevices()
        {
            Console.WriteLine("LIST EXIST DEVICES:");
            DisplayDevices(ListDevice);
        }

        public void DisplayDevices(Device[] devices)
        {
            Console.WriteLine($" ID          Name             Price  Currency");
            for (var i = 0; i < devices.Length; i++)
            {
                if (devices[i] != null)
                {
                    Console.WriteLine($"{devices[i].Id,-4} : {devices[i].Name,-20} {devices[i].Price:f2} {devices[i].Currency,5}");
                }
            }

            Console.WriteLine();
        }
    }
}
