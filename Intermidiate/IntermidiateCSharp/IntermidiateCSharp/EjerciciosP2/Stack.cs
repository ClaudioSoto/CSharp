using System;
using System.Collections;
using System.Collections.Generic;

namespace IntermidiateCSharp
{
    partial class Program
    {
        public class Stack
        {
            public List<int> S = new List<int>();

            public Stack()
            {
                Console.WriteLine("The stack has been initialized");
            }

            public void Push(object value)
            {
                var val = (int)value;
                if (val != null)
                {
                    S.Add(val);
                }
                else
                {
                    throw new InvalidOperationException();
                }

            }

            public int Pop()
            {
                int l = S.Count;
                if (l <= 0)
                {
                    throw new InvalidOperationException();
                }
                else
                {
                    int last = l - 1;
                    int lastValue = S[last];
                    S.RemoveAt(last);
                    return lastValue;
                }
            }

            public void Clear()
            {
                S.Clear();
            }
        }
    }
}
