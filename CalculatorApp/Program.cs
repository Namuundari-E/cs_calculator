using CalculatorLibrary;

namespace CalculatorApp
{
    internal class Program
    {
        static void Main()
        {
            BasicCalculator calculator = new();
            Memory memory = new();

            calculator.Add(10);
            Console.WriteLine($"Result: {calculator.result}");

            calculator.Subtract(3);
            Console.WriteLine($"Result: {calculator.result}");

            memory.Save(calculator.result);
            memory.ShowMemory();

            calculator.Add(5);
            memory.Save(calculator.result);
            memory.ShowMemory();

            memory.Clear();
            memory.ShowMemory();

            Console.ReadLine();
        }
    }
}
 