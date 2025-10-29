using CalculadoraNumerosPrimos.Models;
using CalculadoraNumerosPrimos.Services;

var arguments = new Arguments();

if (args.Length == 0)
{
    arguments = ArgumentsService.GetArgumentsFromUser();
}
else
{
    arguments = ArgumentsService.GetArgumentsFromParameters(args);
}

var startTime = DateTime.Now;
var primeCalculator = new PrimeCalculatorParallelService();
var primeNumbers = primeCalculator.GetPrimeNumbersInRangeParallel(arguments.InitialValue, arguments.FinalValue, arguments.ThreadCount);
var endTime = DateTime.Now;
var duration = endTime - startTime;
Console.WriteLine($"Números primos entre {arguments.InitialValue} e {arguments.FinalValue}:");
Console.WriteLine(string.Join(", ", primeNumbers));
Console.WriteLine($"Tempo decorrido: {duration.TotalMilliseconds} ms");