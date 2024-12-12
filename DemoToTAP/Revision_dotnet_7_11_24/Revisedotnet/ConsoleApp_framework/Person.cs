using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_framework
{
    //Abstraction(Defining Class)
    public class Person
    {
        //Encapsulation(Defining data member)
        public string firstname;
        public string lastname;
        public int age;

        //Constructor Overloading (Function Overloading)
        public Person() {
            this.firstname = "Shubhangi";
            this.lastname = "Tambade";
            this.age = 48;
        }

        public Person(string fname,string lname,int age)
        {
            this.firstname = fname;
            this.lastname = lname;
            this.age = age;
        }

        public override string ToString()
        {
           return "FirstName: " + this.firstname + "  LastName: " + this.lastname + "  Age: " + this.age;
        }
        public void Show()
        {
            Console.WriteLine("FirstName : " + this.firstname + " " + "LastName : " +  this.lastname + " " + "Age : " + this.age);
        }

    }
}
