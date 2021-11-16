using System;
using Module2HW2.Configs;
using Module2HW2.Models;

namespace Module2HW2.Services
{
    public class DataCoefficientService
    {
        private int _capacity;
        private int _countCoefficients = 0;
        private DataCoefficient _dataCoefficients;
        private CurrencyCoefficient[] _tableCoefficients;
        public DataCoefficientService(DataCoefficientConfig dataCoefficientConfig)
        {
            _capacity = dataCoefficientConfig.Capacity;
            _dataCoefficients = new DataCoefficient(_capacity);
            _tableCoefficients = _dataCoefficients.DataCoefficients;
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
