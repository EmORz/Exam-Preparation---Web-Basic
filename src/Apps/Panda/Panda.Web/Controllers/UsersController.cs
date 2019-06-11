using Panda.Service;
using Panda.Web.ViewsModels;
using SIS.MvcFramework;
using SIS.MvcFramework.Attributes;
using SIS.MvcFramework.Result;

namespace Panda.Web.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUsersService usersService;

        public UsersController(IUsersService usersService)
        {
            this.usersService = usersService;
        }

        public IActionResult Register()
        {
            return this.View();
        }
        [HttpPost]
        public IActionResult Register(RegisterInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.Redirect("/Users/Register");
            }

            if (input.Password != input.ConfirmPassword)
            {
                return this.Redirect("/Users/Register");
            }

            var user = usersService.CreateUser(input.Email, input.Password, input.Username);
            this.SignIn(user, input.Username, input.Email);
            return this.Redirect("/");


        }
        [HttpPost]
        public IActionResult Login(LoginInputMode input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.Redirect("/Users/Login");
            }

      

            var user = usersService.GetUserOrNull(input.Username, input.Password);
            if (user == null)
            {
                return this.Redirect("/Users/Login");
            }
            this.SignIn(user.Id, input.Username, input.Password);
            return this.Redirect("/");


        }


        public IActionResult Login()
        {
            return this.View();
        }

        public IActionResult Logout()
        {

            this.SignOut();
            return this.Redirect("/");
        }
    }
}
