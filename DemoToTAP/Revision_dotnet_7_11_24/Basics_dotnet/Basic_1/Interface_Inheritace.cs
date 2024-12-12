using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_1
{
    public interface Iinterface_2
    {
        void interface2_method();
    }
    public interface Iinterface_3
    {
        void interface3_method();
    }

    class Class3: Iinterface_2, Iinterface_3
    {
        public void Display()
        {
            Console.WriteLine("Class1 Display Method.");
        }
        public void interface2_method()
        {
            Console.WriteLine("Iinterface_2 Method.");
        }
        public void interface3_method()
        {
            Console.WriteLine("Iinterface_3 Method.");
        }
    }

}
