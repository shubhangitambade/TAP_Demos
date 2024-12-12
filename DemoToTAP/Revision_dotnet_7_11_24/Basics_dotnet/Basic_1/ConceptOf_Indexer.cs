using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_1
{
    public class StringDataStore
    {
        private string[] strArr = new string[10]; // internal data storage

        public string this[int index]
        {
            get => strArr[index];

            set => strArr[index] = value;
        }
    }
}
