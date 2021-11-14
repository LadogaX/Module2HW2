using Module2HW2.Configs;

namespace Module2HW2.Models
{
    public class Coefficient
    {
        private CoefficientConfig _coefficientConfig;
        public Coefficient(CoefficientConfig coefficientConfig)
        {
            _coefficientConfig = coefficientConfig;
        }

        public Currency Currency { get; init; }

        public double GetCoefficient()
        {
            double coefficient = 0f;
            switch (_coefficientConfig.Currency)
            {
                case Currency.RU:
                    coefficient = _coefficientConfig.RU;
                    break;
                case Currency.UA:
                    coefficient = _coefficientConfig.UA;
                    break;
                case Currency.US:
                    coefficient = 1f;
                    break;
            }

            return coefficient;
        }
    }
}
