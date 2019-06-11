using SIS.MvcFramework.Attributes.Validation;

namespace Panda.Web.ViewModels.User
{
    public class RegisterInputModel
    {
        [RequiredSis]
        [StringLengthSis(5, 20, "Username should be between 5 and 20 characters")]
        public string Username { get; set; }

        [StringLengthSis(5, 20, "Email should be between 5 and 20 characters")]
        [RequiredSis]
        public string Email { get; set; }

        [RequiredSis]
        public string Password { get; set; }

        public string ConfirmPassword { get; set; }

        /*abel for="username" class="text-panda">Username</label>
            <input type="text" class="form-control" id="username" name="username" placeholder="Username..." />
        </div>
        <div class="form-group">
            <label for="email" class="text-panda">Email</label>
            <input type="email" class="form-control" id="email" name="email" placeholder="Email..." />
        </div>
        <div class="form-group">
            <label for="password" class="text-panda">Password</label>
            <input type="password" class="form-control" id="password" name="password" placeholder="Password..." />
        </div>
        <div class="form-group">
            <label for="confirmPassword" class="text-panda">Confirm Password</label>*/
    }
}