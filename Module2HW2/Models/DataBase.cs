using Module2HW2.Services;
using Module2HW2.Models;

namespace Module2HW2.Models
{
    public class DataBase
    {
        private static readonly DataBase _instance = new DataBase();

        static DataBase()
        {
        }

        private DataBase()
        {
            FillDevice();
        }

        public static DataBase Instance => _instance;
        public Device[] ListDevice { get; private set; }

        private void FillDevice()
        {
            ListDevice = new Device[8];
            ListDevice[0] = new Device { Id = 1, Name = "Apple", Model = "12", Currency = Currency.US, Price = 2000 };
            ListDevice[1] = new Device { Id = 2, Name = "OnePlus", Model = "9D", Currency = Currency.US, Price = 700 };
            ListDevice[2] = new Device { Id = 3, Name = "Oppo", Model = "7R", Currency = Currency.US, Price = 650 };
            ListDevice[3] = new Device { Id = 4, Name = "Poco", Model = "15G", Currency = Currency.US, Price = 500 };
            ListDevice[4] = new Device { Id = 5, Name = "Realme", Model = "8HH", Currency = Currency.US, Price = 800 };
            ListDevice[5] = new Device { Id = 6, Name = "Samsung", Model = "A72", Currency = Currency.US, Price = 750 };
            ListDevice[6] = new Device { Id = 7, Name = "Vivo", Model = "V7", Currency = Currency.US, Price = 500 };
            ListDevice[7] = new Device { Id = 8, Name = "Xiaomi", Model = "5F", Currency = Currency.US, Price = 675 };
        }

        // public string AllLogs => _logs.ToString();
    }
}