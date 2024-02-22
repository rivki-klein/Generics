using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class SwapList<T> : List<T>

    {
     
        public SwapList() { }
        public void MySwap(int i, int j)
        {
            T temp = this[i];
            this[i] = this[j];
            this[j] = temp;
        }
    }
}
