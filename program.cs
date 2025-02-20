using System;
using calculator;

namespace Calculator
{
    internal class Program
    {
        static void Main()
        {
            BasicCalculator mashin = new BasicCalculator();
            Memory memory = new Memory();

            mashin.Add(10);
            Console.WriteLine($"Hariu: {mashin.result}");

            mashin.Subtract(3);
            Console.WriteLine($"Hariu: {mashin.result}");

            memory.Save(mashin.result);
            memory.ShowMemory();

            mashin.Add(5);
            memory.Save(mashin.result);
            memory.ShowMemory();

            memory.Clear();
            memory.ShowMemory();
        }
    }
}
