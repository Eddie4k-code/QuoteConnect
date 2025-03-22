using UserService.Application.Results;
using Microsoft.AspNetCore.Mvc;
using UserService.Application.Interfaces.Persistence;

namespace UserService.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class  UserController : ControllerBase
    {

        private readonly IAuthenticationService _userService;

        public UserController(IAuthenticationService userService)
        {
            this._userService = userService;
        }

        [HttpPost]
        
        public async Task<UserResult> Login(string username, string password)
        {

            
            return await _userService.Login(username, password);
        }  
    }
}