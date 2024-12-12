using AuthWebAPI.Model;
using AuthWebAPI.AuthContextDB;
using Microsoft.EntityFrameworkCore;
namespace AuthWebAPI.Services
{
    public class UserService : IUserService
    {
        private readonly UserDBContext _dbContext;

        public UserService(UserDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<User> ValidateUser(string email, string password)
        {
            User user = await _dbContext.Users.FirstOrDefaultAsync(x => x.Email == email && x.Password == password); 

            return user;
        }

        public async Task<List<User>> GetAll()
        {
            List<User> users = await _dbContext.Users.ToListAsync();
            return users;
        }
    }
}
