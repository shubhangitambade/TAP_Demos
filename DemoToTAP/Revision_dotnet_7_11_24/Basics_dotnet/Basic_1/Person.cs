using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_indexer
{
    //to block inheritance we use sealed keyword
    public sealed class Person
    {
        public double PI;
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Create class Singleton

        //Step 1: Create Person Reference set it to null
        public static Person _ref = null;

        //Step 2:Singleton Pattern
         Person()
        {
            this.FirstName = "Ravi";
            this.LastName = "Tambade";
            this.Id = 455;
            this.PI = 3.14;
        }
        //Step 3 :
        public static Person CreateInstance()  //static method allow static references or object
        {
            if(_ref == null)
            {
                _ref =  new Person();
            }
            return _ref;       
        }

        public  int GetId
        {
            get{

                return _ref.Id;
            }
            
        }

        public  string GetFirstName
        {
            get
            {
                return _ref.FirstName;
            }
            
        }

        public string GetLastName
        {

            get
            {
                return _ref.LastName;
            }
            
        }

        public int GId()
        {
            return _ref.Id;
        }

        public  void display()
        {
            Console.WriteLine("Id : " + GId() + "FirstName :" + GetFirstName + " LastName : " + LastName);
        }
    }

    /*public class Employee :Person  //Error:Employee can't be inheritted from Person
    {

    }*/
}
