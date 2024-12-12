using Microsoft.AspNetCore.Mvc;
using EmployeDbContext.Models;

namespace EmployeDbContext.Services
{
    
    public class UserService
    {
        public List<User> users;
        public UserService() {

            users = new List<User>();
            users.Add(new User { Uname = "Ravi", Password = "tfl@123" });
            users.Add(new User { Uname = "Shubhangi" ,Password = "tfl@789" });
            
        }

        public User UserValidate(string uname,string password)
        {

            return users.FirstOrDefault(user => user.Uname == uname && user.Password == password);
            
        }

    }
}
