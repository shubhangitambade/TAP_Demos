using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_framework
{
    public class Employee:Person
    {
        private int Id;
        private double da;
        private double hra;
        private double daysworking;

        public Employee()
        {
            this.Id = 1;
            this.da = 0.10;
            this.hra = 0.25;
            this.daysworking = 30;
        }
        public Employee(string _fname,string _lname,int _age,int _id,double _da,double _hra,double _daysworking) : base(_fname, _lname, _age)
        {
            this.Id = _id;
            this.da = _da;
            this.hra = _hra;
            this.daysworking= _daysworking;
        }

        public override string ToString()
        {
            return base.ToString() + " Id: " + this.Id + "  Da: " + this.da + "  Hra: "+ this.hra + "  daysworkin: " + this.daysworking ;
        }
        public void show()
        {
            base.Show();
            Console.WriteLine("  Id : " + this.Id + "  Da : " + this.da + "  Hra : " + this.hra + "  DaysWorking : " + this.daysworking);
        }
        
    }
}
