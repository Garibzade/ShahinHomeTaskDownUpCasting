using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskDownCasUpCas.ClassTask
{
    internal class IntArrayLıst
    {
        public IntArrayLıst()
        {
            _arr = new int[Capacity];
        }
        public IntArrayLıst(int capacity)
        {
            Capacity = capacity;
            _arr = new int[Capacity];
        }

        int[] _arr;
        public int Capacity { get; set; } = 5;
        public int Count { get; private set; } = 0;

        public void Add(int value)
        {
            if (_arr.Length == Count)
            {
                Array.Resize(ref _arr, Count + Capacity);
            }
            _arr[Count] = value;
            Count++;
        }

        public void GetElements()
        {
        for (int i = 0; i < Count; i++) 
            {
                Console.WriteLine(_arr[i]);
            }
        }    
    }
}
