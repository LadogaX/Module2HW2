using Module2HW2.Models;
using Module2HW2.Configs;

namespace Module2HW2.Configs
{
    public class Config
    {
        public Config()
        {
        }

        public CartConfig CartConfig { get; set; }
        public Currency Currency { get; set; }
        public int IncrenentCapacityOrder { get; set; }

        public CoefficientConfig CoefficientConfig { get; set; }
    }
}
