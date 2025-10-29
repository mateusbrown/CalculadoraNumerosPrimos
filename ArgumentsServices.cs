using CalculadoraNumerosPrimos.Models;
namespace CalculadoraNumerosPrimos.Services
{
    public class ArgumentsService
    {
        public static Arguments GetArgumentsFromUser()
        {
            var arguments = new Arguments();

            Console.WriteLine("Informe o início do intervalo:");
            arguments.InitialValue = int.Parse(Console.ReadLine() ?? "");

            Console.WriteLine("Informe o fim do intervalo:");
            arguments.FinalValue = int.Parse(Console.ReadLine() ?? "");

            Console.WriteLine("Informe o número de threads/tarefas:");
            arguments.ThreadCount = int.Parse(Console.ReadLine() ?? "");

            return arguments;
        }

        public static Arguments GetArgumentsFromParameters(string[] args)
        {
            var arguments = new Arguments();

            if (args.Length >= 1)
            {
                arguments.InitialValue = int.Parse(args[0]);
            }

            if (args.Length >= 2)
            {
                arguments.FinalValue = int.Parse(args[1]);
            }

            if (args.Length >= 3)
            {
                arguments.ThreadCount = int.Parse(args[2]);
            }

            return arguments;
        }
    }
}