using System.Numerics;
using System.Runtime.CompilerServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LektierOpg1til6.Pages
{
    public partial class Calculator
    {
        public double number1 = 0;
        public double number2 = 0;
        public double total = 0;

        public void CalculateAdd() => total = number1 + number2;
        public void CalculateMinus() => total = number1 - number2;
        public void CalculateGange() => total = number1*number2;
        public void CalculateDiv()
        {
            total=number1/number2;
        }

        public void CalculateFakultet()
        {
            total =fakultet(number1);
        }

        private double fakultet(double n)
        {
            if (n < 0)
              return 0;
            double result = 1;
           
            for (double i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}

