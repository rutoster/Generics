using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lissonfour
{
    public class SwapL<T>:List<T>
    {
        public void SwapList(int A,int B)
        {
            T temp = this[A];
            this[A] = this[B];
            this[B] = temp;
        }
    }
}
