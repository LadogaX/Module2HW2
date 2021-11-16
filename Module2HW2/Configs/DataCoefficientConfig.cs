using System;
using Module2HW2.Models;
using Module2HW2.Services;
using Module2HW2.Provides;

namespace Module2HW2.Configs
{
    public class DataCoefficientConfig
    {
        private CurrencyCoefficient[] _tableCoefficients;
        private int _countCoefficients = 0;
        private int _capacity = 5;
        public DataCoefficientConfig()
        {
            DataCoefficient dataCoefficient = new DataCoefficient(_capacity);

            _tableCoefficients = dataCoefficient.DataCoefficients;
        }

        public void AddCoefficient(CurrencyCoefficient coefficient)
        {
            for (var i = _countCoefficients; i < _tableCoefficients.Length; i++)
            {
                if (_tableCoefficients[i] == null)
                {
                    _tableCoefficients[i] = coefficient;
                    _countCoefficients++;
                    break;
                }
                else
                {
                    SetCapacity(_capacity);
                }
            }
        }

        public CurrencyCoefficient GetCoefficient(Currency currency)
        {
            CurrencyCoefficient findingCoeffcient = null;
            foreach (CurrencyCoefficient coefficient in _tableCoefficients)
            {
                if (coefficient.Currency == currency)
                {
                    findingCoeffcient = coefficient;
                    break;
                }
            }

            return findingCoeffcient;
        }

        private void SetCapacity(int capacity)
        {
            Array.Resize(ref _tableCoefficients, capacity);
        }
    }
}