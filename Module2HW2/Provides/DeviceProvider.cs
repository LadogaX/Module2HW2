using Module2HW2.Services;
using Module2HW2.Models;
using Module2HW2.Provides;

namespace Module2HW2.Provides
{
    public class DeviceProvider
    {
        public DeviceProvider(DataBase dataBase)
        {
            DataBase = dataBase;
        }

        private DataBase DataBase { get; init; }

        public Device GetDevice(int id_device)
        {
            Device device = null;
            Device[] listDevice = DataBase.ListDevice;

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
            Device[] listDevice = DataBase.Instance.ListDevice;

            return listDevice;
        }
    }
}