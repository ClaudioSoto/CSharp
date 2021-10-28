using System;
using System.Collections;
using System.Collections.Generic;

namespace IntermidiateCSharp
{
    partial class Program
    {
        public class Stack
        {
            private List<object> _S = new List<object>();

            public Stack()
            {
                Console.WriteLine("The stack has been initialized");
            }

            public void Push(object value)
            {
                if (value == null)
                    throw new InvalidOperationException();
                _S.Add(value);
            }

            public int Pop()
            {
                int l = _S.Count;
                if (l <= 0)
                    throw new InvalidOperationException();
                int last = l - 1;
                int lastValue = (int)_S[last];
                _S.RemoveAt(last);
                return lastValue;
            }
            public void Clear()
            {
                _S.Clear();
            }
        }
    }
}
