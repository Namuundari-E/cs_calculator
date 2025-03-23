using System;

namespace CalculatorLibrary
{
    public class BasicCalculator : Result, Uildel
    {
        public void Add(double number)
        {
            result += number;
            Console.WriteLine($"Adding number {number}");
        }

        public void Subtract(double number)
        {
            result -= number;
            Console.WriteLine($"Subtracting number {number}");
        }
        public void Multiply(double number)
        {
            result *= number; // Multiplies the result by the number
        }

        public void Divide(double number)
        {
            if (number != 0)
            {
                result /= number; // Divides the result by the number
            }
            else
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
        }
    }
}
