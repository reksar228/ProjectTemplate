using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTempalte
{
    public class Stack<T>
    {
        protected T[] values; // здесь будут храниться значения
        private int size;   // количество значений, хранимых на стеке. но не фактических, а "валидных"

        public int Size { get => size; }

        public Stack(int capacity = 10)
        {
            values = new T[capacity];
            size = 0;
        }


        public void Push(T value)
        {
            if (size < values.Length)
            {
                values[size++] = value;
            }
            else
            {
                Array.Resize(ref values, size * 2);
                values[size++] = value;
            }
        }


        public T Pop()
        {
            if (size > 0)
            {
                size--;
                return values[size];
            }
            else
            {
                throw new InvalidOperationException("В массиве values не содержится ни один элемент");
            }
        }

        // TODO:
        // Аналогично предыдущему, но ничего не удаляем
        public T Peek()
        {
            if (size > 0)
            {
                return values[size - 1];
            }
            else
            {
                throw new InvalidOperationException("В массиве values не содержится ни один элемент");
            }
        }

        public bool IsEmpty()
        {
            return size == 0;
        }
    }
}
