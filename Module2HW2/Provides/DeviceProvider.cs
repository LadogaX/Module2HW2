using Module2HW2.Services;
using Module2HW2.Models;
using Module2HW2.Provides;

namespace Module2HW2.Provides
{
    public class DeviceProvider
    {
        public Device GetDevice(int id_device)
        {
            Device device = null;
            var listDevice = GetAllDevices();

            for (var i = 0; i < listDevice.Length; i++)
            {
                if (listDevice[i].Id == id_device)
                {
                    device = new Device();
                    device = listDevice[i];
                    break;
                }
            }

            return device;
        }

        public Device[] GetAllDevices()
        {
            var listDevice = new Device[8];

            listDevice[0] = new Device { Id = 1, Name = "Apple", Model = "12", Currency = Currency.USD, Price = 2000 };
            listDevice[1] = new Device { Id = 2, Name = "OnePlus", Model = "9D", Currency = Currency.USD, Price = 700 };
            listDevice[2] = new Device { Id = 3, Name = "Oppo", Model = "7R", Currency = Currency.USD, Price = 650 };
            listDevice[3] = new Device { Id = 4, Name = "Poco", Model = "15G", Currency = Currency.USD, Price = 500 };
            listDevice[4] = new Device { Id = 5, Name = "Realme", Model = "8HH", Currency = Currency.USD, Price = 800 };
            listDevice[5] = new Device { Id = 6, Name = "Samsung", Model = "A72", Currency = Currency.USD, Price = 750 };
            listDevice[6] = new Device { Id = 7, Name = "Vivo", Model = "V7", Currency = Currency.USD, Price = 500 };
            listDevice[7] = new Device { Id = 8, Name = "Xiaomi", Model = "5F", Currency = Currency.USD, Price = 675 };

            return listDevice;
        }
    }
}