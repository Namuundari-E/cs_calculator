using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    
    class Memory
    {
        private List<MemoryItem> memoryItems = new List<MemoryItem>();

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
    }
    class MemoryItem
    {
        public double Value;
        public MemoryItem(double a)
        {
            this.Value = a;
        }
        
    }

}
