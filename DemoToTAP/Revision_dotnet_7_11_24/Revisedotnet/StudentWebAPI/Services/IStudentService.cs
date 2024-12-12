using StudentPortalWebAPI.Entities;

namespace StudentPortalWebAPI.Services
{
    public interface IStudentService
    {
        Task<List<Student>> getAllStudentsAsync();
        Task<Address> getAddressByStudentId(int id);
        Task<Student> getAllStudentByIdAsync(int id);
    }
}
