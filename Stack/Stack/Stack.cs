using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class Stack<T>
    {
        public Stack(int size)
        {
            
        }
        public void Push(T item)
        {
            item.Push(1);
            item.Push(2);
            item.Push(3);
        }
        public T Pop()
        {
            T t = default(T);
            int pop = Stack.Pop();
            return t;
        }
        public T Peek()
        {
            T t = default(T);
            if (T.Count > 0)
            {
                Console.WriteLine(t.Peek()); // prints 4
                Console.WriteLine(t.Peek()); // prints 4
                return t;
            }
        }
        public int Count()
        {
            return 0;
        }
    }
}
