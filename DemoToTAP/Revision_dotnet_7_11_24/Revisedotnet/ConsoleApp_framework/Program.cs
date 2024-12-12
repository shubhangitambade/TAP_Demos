using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_framework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 50;
            count++;
            bool status = false;
            string company = "Transflower";
            DateTime curentDate = DateTime.Now;
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Count : " + count);
            Console.WriteLine("Company : " + company);
            Console.WriteLine("Status : " + status);
            Console.WriteLine("Current DateTime : " + curentDate);


            Employee employee = new Employee("Aarav","Despande",21,101,0.12,0.20,30);
            Console.WriteLine(employee);
            //employee.show();
            Console.ReadLine();

        }
    }
}
