using System.Collections.Generic;
using System.Threading.Tasks;
using System.Collections.Concurrent;

namespace CalculadoraNumerosPrimos.Services
{
    public class PrimeCalculatorParallelService
    {
        public List<int> GetPrimeNumbersInRangeParallel(int initialValue, int finalValue, int threadCount)
        {
            var primeNumbers = new ConcurrentBag<int>();
            var rangeSize = (finalValue - initialValue + 1) / threadCount;
            var tasks = new List<Task>();

            for (int i = 0; i < threadCount; i++)
            {
                int start = initialValue + i * rangeSize;
                int end = (i == threadCount - 1) ? finalValue : start + rangeSize - 1;

                tasks.Add(Task.Run(() =>
                {
                    var primeNumberService = new PrimeNumberService();
                    foreach (int prime in primeNumberService.GetPrimeNumbersInRange(start, end))
                    {
                        primeNumbers.Add(prime);
                    }
                }));
            }

            Task.WaitAll(tasks.ToArray());

            return primeNumbers.OrderBy(n => n).ToList();
        }
    }
}