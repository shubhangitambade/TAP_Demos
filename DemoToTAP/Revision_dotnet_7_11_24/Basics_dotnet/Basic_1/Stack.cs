using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_1
{
    public class Stack : ICloneable
    {
        private int size;
        private int[]  sArr;
        public Stack(int s) {
            this.size = s;
            this.sArr = new int[size];

        }
        //Deep Copy Implementation
        public object Clone()
        {
            Stack stackClone = new Stack(this.size);
            this.sArr.CopyTo(stackClone.sArr, 0);  

            return stackClone;
        }
    }
}
