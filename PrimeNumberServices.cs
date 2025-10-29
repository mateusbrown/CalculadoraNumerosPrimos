using CalculadoraNumerosPrimos.Models;

namespace CalculadoraNumerosPrimos.Services
{
    public class PrimeNumberService
    {
        public List<int> GetPrimeNumbersInRange(int initialValue, int finalValue)
        {
            var primeNumbers = new List<int>();

            for (int number = initialValue; number <= finalValue; number++)
            {
                if (IsPrime(number))
                {
                    primeNumbers.Add(number);
                }
            }

            return primeNumbers;
        }

        private bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            for (int i = 3; i <= Math.Sqrt(number); i += 2)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
    }
}