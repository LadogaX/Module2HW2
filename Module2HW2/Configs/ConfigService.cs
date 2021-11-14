using Module2HW2.Configs;

namespace Module2HW2.Services
{
    public class ConfigService
    {
        public ConfigService()
        {
            Config = new Config();
            Init();
        }

        public Config Config { get; set; }
        public CoefficientConfig GetCoefficientConfig()
        {
            return Config.CoefficientConfig;
        }

        public CartConfig GetCartConfig()
        {
            return Config.CartConfig;
        }

        private void Init()
        {
            Config.CartConfig = new CartConfig();
            Config.CartConfig.Capacity = 10;
            Config.IncrenentCapacityOrder = 2;
            Config.Currency = Models.Currency.UA;

            Config.CoefficientConfig = new CoefficientConfig(Config.Currency);
            Config.CoefficientConfig.RU = 81f;
            Config.CoefficientConfig.UA = 35f;
        }
    }
}
