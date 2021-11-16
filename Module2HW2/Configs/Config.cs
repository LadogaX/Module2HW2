using Module2HW2.Models;
using Module2HW2.Configs;

namespace Module2HW2.Configs
{
    public class Config
    {
        public Config()
        {
            CartConfig = new CartConfig();
            DataCoefficientConfig = new DataCoefficientConfig();
        }

        public CartConfig CartConfig { get; set; }
        public Currency Currency { get; set; }
        public int IncrenentCapacityOrder { get; set; }

        public DataCoefficientConfig DataCoefficientConfig { get; set; }
    }
}
