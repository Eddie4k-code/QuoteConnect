using UserService.Application;

namespace UserService.API.Controllers
{
    public class  UserController : ControllerBase
    {

        private readonly IAuthenticationService _userService;

        public UserController(IAuthenticationService userService)
        {
            this._userService = userService;
        }


        public async Task<UserResult> Login(string username, string password)
        {
            return await _userService.Login(username, password);
        }






        
    }
}