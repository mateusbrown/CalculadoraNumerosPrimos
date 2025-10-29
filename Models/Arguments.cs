namespace CalculadoraNumerosPrimos.Models
{
    public class Arguments
    {
        public int InitialValue { get; set; } = int.MinValue;
        public int FinalValue { get; set; } = int.MaxValue;
        public int ThreadCount { get; set; } = 4;
    }
}
