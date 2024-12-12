using AuthWebAPI.Model;

namespace AuthWebAPI.Services
{
    public interface IUserService
    {
        Task<User> ValidateUser(string email, string password);

        Task<List<User>> GetAll();
    }
}
