using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW2.Models
{
    public class DataCoefficient
    {
        public DataCoefficient(int capacity)
        {
            DataCoefficients = new CurrencyCoefficient[capacity];
        }

        public CurrencyCoefficient[] DataCoefficients { get; set; }
    }
}
