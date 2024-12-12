using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entity_CodeFirst_Employee.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Email { get; set; }
        public string ContactNo { get; set; }

        public override string ToString()
        {
            return this.Id + " " + this.FName + " " + this.LName + " " + this.Email + " " + this.ContactNo;
        }
    }
}