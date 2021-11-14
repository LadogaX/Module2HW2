using System;
using Module2HW2.Models;
using Module2HW2.Services;
using Module2HW2.Provides;

namespace Module2HW2.Configs
{
    public class CoefficientConfig
    {
        private Coefficient _coefficient;

        public CoefficientConfig(Currency currency)
        {
            Currency = currency;
            _coefficient = new Coefficient(this);
        }

        public double UA { get; set; }
        public double RU { get; set; }

        public Currency Currency { get; set; }

        public double GetCoefficient()
        {
           return _coefficient.GetCoefficient();
        }
    }
}