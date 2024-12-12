using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_1
{
    public  class Param_ref_out
    {

        public void Display(params string[] subjects)
        {
            foreach (string s in subjects)
                Console.WriteLine(s);
        }

        public void Swap(ref int num1, ref int num2)
        {
            int temp;
            temp = num1;
            num1 = num2;
            num2 = temp;

        }

        public void Calculate(int radius, out double area, out double circumference)
        {
            double PI = 3.14;
            area = PI * radius * radius;
            circumference = 2 * PI * radius;
            Console.WriteLine("Circumference  = " + circumference);
        }
    }
}
