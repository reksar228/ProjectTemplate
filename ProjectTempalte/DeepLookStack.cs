using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTempalte
{

    class DeepLookStack<T> : Stack<T> 
    {
        public T Peek(int shift)
        {
            return values[Size - shift - 1];
        }
    }
}
