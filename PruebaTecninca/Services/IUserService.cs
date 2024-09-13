using PruebaTecninca.DTO;

namespace PruebaTecninca.Services
{
    public interface IUserService
    {
        Task<UserDTO> CreateUser(string name, string mail, string password);
        Task<List<UserDTO>> GetAllUsers();
        Task<UserDTO> UpdateUser(Guid id, string? newName, string? newMail, string? newPassword);
        Task<bool> DeleteUser(Guid id);
    }
}
