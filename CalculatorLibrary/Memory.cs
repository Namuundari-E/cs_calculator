using System;
using System.Collections.Generic;

namespace CalculatorLibrary
{
    public class Memory
    {
        private readonly List<MemoryItem> memoryItems = new();

        public void Save(double value)
        {
            memoryItems.Add(new MemoryItem(value));
        }

        public void Clear()
        {
            memoryItems.Clear();
        }

        public void ShowMemory()
        {
            if (memoryItems.Count == 0)
            {
                Console.WriteLine("Memory is empty.");
                return;
            }

            Console.WriteLine("Memory:");
            foreach (var item in memoryItems)
            {
                Console.WriteLine(item);
            }
        }
        public List<MemoryItem> GetMemoryItems()
        {
            return memoryItems;
        }
        public void AddToLast(double value)
        {
            if (memoryItems.Count > 0)
            {
                double newValue = memoryItems[memoryItems.Count - 1].Value + value;
                memoryItems[memoryItems.Count - 1] = new MemoryItem(newValue); 
            }
        }

        public void SubtractFromLast(double value)
        {
            if (memoryItems.Count > 0)
            {
                double newValue = memoryItems[memoryItems.Count - 1].Value - value;
                memoryItems[memoryItems.Count - 1] = new MemoryItem(newValue); 
            }
        }
        public void RemoveAt(int index)
        {
            if (index >= 0 && index < memoryItems.Count)
                memoryItems.RemoveAt(index);
        }

    }
}