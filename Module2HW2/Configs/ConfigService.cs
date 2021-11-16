using Module2HW2.Configs;
using Module2HW2.Models;

namespace Module2HW2.Services
{
    public class ConfigService
    {
        public ConfigService()
        {
            Config = new Config();
        }

        public Config Config { get; set; }
        public DataCoefficientConfig GetCoefficientConfig()
        {
            return Config.CoefficientConfig;
        }

        public CartConfig GetCartConfig()
        {
            return Config.CartConfig;
        }

        public CurrencyCoefficient GetCoefficient()
        {
            return Config.CoefficientConfig.GetCoefficient(Currency.UAH);
        }

        public void Init(Currency currency)
        {
            Config.CartConfig.Capacity = 10;
            Config.IncrenentCapacityOrder = 2;
            Config.Currency = currency;

            Config.CoefficientConfig.AddCoefficient(new CurrencyCoefficient { Currency = Currency.EUR, Value = 1.2f });
            Config.CoefficientConfig.AddCoefficient(new CurrencyCoefficient { Currency = Currency.RUB, Value = 80f });
            Config.CoefficientConfig.AddCoefficient(new CurrencyCoefficient { Currency = Currency.UAH, Value = 29.5f });
            Config.CoefficientConfig.AddCoefficient(new CurrencyCoefficient { Currency = Currency.USD, Value = 1f });
        }
    }
}
