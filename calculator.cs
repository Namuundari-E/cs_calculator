using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class BasicCalculator:Result, Uildel
    {
        public void Add(double number)
        {
            result += number;
            Console.WriteLine($"adding number {number}");
        }

        public void Subtract(double number)
        {
            result -= number;
            Console.WriteLine($"substracting numbr {number}");
        }
    }
}
