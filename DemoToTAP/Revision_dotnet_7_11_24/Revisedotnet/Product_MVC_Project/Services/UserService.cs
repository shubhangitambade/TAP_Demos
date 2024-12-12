using Microsoft.EntityFrameworkCore;
using Product_MVC_Project.Models;
using Product_MVC_Project.UserDbContext;

namespace Product_MVC_Project.Services
{
    public class UserService:IUserService
    {
     
        UserContext _userContext;
        public UserService(UserContext userContext)
        {
            _userContext = userContext;
        }

        async Task<User> IUserService.ValidateUser(string email, string password)
        {
            User user = await _userContext.Users.FirstOrDefaultAsync(x => x.Email == email && x.Password == password);
            Console.WriteLine(user);
            return user;

        }

        /*async Task<string[]> IUserService.GetRols(string email)
        {
            return await _userContext.Users.FirstOrDefaultAsync(u => u.Email == email)?_userContext.Users.Roles ?? new string[0];
        }*/
    }
}
