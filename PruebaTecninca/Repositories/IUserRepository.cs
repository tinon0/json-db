using PruebaTecninca.Models;

namespace PruebaTecninca.Repositories
{
    public interface IUserRepository
    {
        Task<User> CreateUser(string name, string mail, string password);
        Task<List<User>> GetAllUsers();
        Task<User> UpdateUser(Guid id, string? newName, string? newMail, string? newPassword);
        Task<bool> DeleteUser(Guid id);
    }
}
