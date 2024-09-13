using Microsoft.AspNetCore.Mvc;
using PruebaTecninca.Response;
using PruebaTecninca.Services;
using PruebaTecninca.Commands;

namespace PruebaTecninca.Controllers
{
    [ApiController]
    [Route("/{api}")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService _userService)
        {
            this._userService = _userService;
        }
        [HttpPost]
        [Route("/createUser")]
        public async Task<ResultBase> CreateUser(NewUser newUser)
        {
            var result = new ResultBase();
            try
            {
                result.Result = await _userService.CreateUser(newUser.Name, newUser.Mail, newUser.Password);
                result.StatusCode = 200;
                result.Ok = true;
                result.Error = string.Empty;
                result.MessageInfo = "User created successfully";

                return result;
            }
            catch (Exception ex)
            {
                result.Result = null;
                result.StatusCode = 500;
                result.Ok = false;
                result.Error = "There was an error";
                result.MessageInfo = ex.Message;

                return result;
            }
        }
        [HttpGet]
        [Route("/getAllUsers")]
        public async Task<ResultBase> GetAllUsers()
        {
            var result = new ResultBase();
            try
            {
                result.Result = await _userService.GetAllUsers();
                result.StatusCode = 200;
                result.Ok = true;
                result.Error = string.Empty;
                result.MessageInfo = "User found successfully";

                return result;
            }
            catch (Exception ex)
            {
                result.Result = null;
                result.StatusCode = 500;
                result.Ok = false;
                result.Error = "There was an error";
                result.MessageInfo = ex.Message;

                return result;
            }
        }
        [HttpPatch]
        [Route("/updateUser")]
        public async Task<ResultBase> UpdateUser(SearchUser user)
        {
            var result = new ResultBase();
            try
            {
                result.Result = await _userService.UpdateUser(user.Id, user.Name, user.Mail, user.Password);
                result.StatusCode = 200;
                result.Ok = true;
                result.Error = string.Empty;
                result.MessageInfo = "User updated successfully";

                return result;
            }
            catch (Exception ex)
            {
                result.Result = null;
                result.StatusCode = 500;
                result.Ok = false;
                result.Error = "There was an error";
                result.MessageInfo = ex.Message;

                return result;
            }
        }
        [HttpDelete]
        [Route("/deleteUser/{id}")]
        public async Task<ResultBase> DeleteUser(Guid id)
        {
            var result = new ResultBase();
            try
            {
                result.Result = await _userService.DeleteUser(id);
                result.StatusCode = 200;
                result.Ok = true;
                result.Error = string.Empty;
                result.MessageInfo = "User deleted successfully";

                return result;
            }
            catch (Exception ex)
            {
                result.Result = null;
                result.StatusCode = 500;
                result.Ok = false;
                result.Error = "There was an error";
                result.MessageInfo = ex.Message;

                return result;
            }
        }
    }
}
