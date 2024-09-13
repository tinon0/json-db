using AutoMapper;
using PruebaTecninca.DTO;
using PruebaTecninca.Repositories;

namespace PruebaTecninca.Services.Impl
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public UserService(IUserRepository _userRepository, IMapper _mapper)
        {
            this._userRepository = _userRepository;
            this._mapper = _mapper;
        }

        public async Task<UserDTO> CreateUser(string name, string mail, string password)
        {
            var newUser = await _userRepository.CreateUser(name, mail, password);
            var newUserDTO = _mapper.Map<UserDTO>(newUser);
            return newUserDTO;
        }

        public Task<bool> DeleteUser(Guid id)
        {
            return _userRepository.DeleteUser(id);
        }

        public async Task<List<UserDTO>> GetAllUsers()
        {
            var users = await _userRepository.GetAllUsers();
            var usersDTO = _mapper.Map<List<UserDTO>>(users);
            return usersDTO;
        }

        public async Task<UserDTO> UpdateUser(Guid id, string? newName, string? newMail, string? newPassword)
        {
            var userUpdated = await _userRepository.UpdateUser(id, newName, newMail, newPassword);
            var userUpdatedDTO = _mapper.Map<UserDTO>(userUpdated);
            return userUpdatedDTO;
        }
    }
}
