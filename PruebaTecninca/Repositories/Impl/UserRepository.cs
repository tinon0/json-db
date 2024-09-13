using Microsoft.EntityFrameworkCore;
using PruebaTecninca.Data;
using PruebaTecninca.Models;

namespace PruebaTecninca.Repositories.Impl
{
    public class UserRepository : IUserRepository
    {
        private readonly ContextDB _context;
        public UserRepository(ContextDB _context)
        {
            this._context = _context;
        }

        public async Task<User> CreateUser(string name, string mail, string password)
        {
            var newUser = new User();
            newUser.Id = Guid.NewGuid();
            newUser.Name = name;
            newUser.Mail = mail;
            newUser.Password = password;

            _context.Users.Add(newUser);
            await _context.SaveChangesAsync();

            return newUser;
        }

        public async Task<bool> DeleteUser(Guid id)
        {
            var userSearched = await _context.Users.FirstOrDefaultAsync(user => user.Id.Equals(id));

            if (userSearched != null)
            {
                _context.Users.Remove(userSearched);
                await _context.SaveChangesAsync();
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<List<User>> GetAllUsers()
        {
            var users = await _context.Users.ToListAsync();
            return users;
        }

        public async Task<User> UpdateUser(Guid id, string? newName, string? newMail, string? newPassword)
        {
            var userToUpdate = await _context.Users.FirstOrDefaultAsync(user => user.Id.Equals(id));

            if (newName != null)
            {
                userToUpdate.Name = newName;
            }
            if (newMail != null)
            {
                userToUpdate.Mail = newMail;
            }
            if (newPassword != null)
            {
                userToUpdate.Password = newPassword;
            }

            _context.Users.Update(userToUpdate);
            await _context.SaveChangesAsync();

            return userToUpdate;
        }
    }
}
