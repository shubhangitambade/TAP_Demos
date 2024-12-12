using Product_MVC_Project.Models;

namespace Product_MVC_Project.Services
{
    public interface IUserService
    {
        Task<User> ValidateUser(string email,string password);
        //Task<string[]> GetRols(string email);
    }
}
