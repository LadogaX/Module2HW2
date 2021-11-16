using Module2HW2.Configs;
using Module2HW2.Models;

namespace Module2HW2.Services
{
    public class ConfigService
    {
        private DataCoefficientService _dataCoefficientService;

        public ConfigService()
        {
            Config = new Config();
        }

        public Config Config { get; set; }
        public DataCoefficientConfig GetDataCoefficientConfig()
        {
            return Config.DataCoefficientConfig;
        }

        public CartConfig GetCartConfig()
        {
            return Config.CartConfig;
        }

        public CurrencyCoefficient GetCoefficient()
        {
            return _dataCoefficientService.GetCoefficient(Currency.UAH);
        }

        public void Init(Currency currency)
        {
            Config.CartConfig.Capacity = 10;
            Config.DataCoefficientConfig.Capacity = 5;
            Config.IncrenentCapacityOrder = 2;
            Config.Currency = currency;

            _dataCoefficientService = new DataCoefficientService(GetDataCoefficientConfig());

            _dataCoefficientService.AddCoefficient(new CurrencyCoefficient { Currency = Currency.EUR, Value = 1.2f });
            _dataCoefficientService.AddCoefficient(new CurrencyCoefficient { Currency = Currency.RUB, Value = 80f });
            _dataCoefficientService.AddCoefficient(new CurrencyCoefficient { Currency = Currency.UAH, Value = 29.5f });
            _dataCoefficientService.AddCoefficient(new CurrencyCoefficient { Currency = Currency.USD, Value = 1f });
        }
    }
}
