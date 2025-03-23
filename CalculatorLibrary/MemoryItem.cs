namespace CalculatorLibrary
{
    public class MemoryItem
    {
        public double Value { get; private set; }

        public MemoryItem(double value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}