using System;
using System.Collections.Generic;
using System.Text;
using SIS.MvcFramework.Attributes.Validation;

namespace Panda.Web.ViewsModels
{
    public class LoginInputMode
    {
        [RequiredSis]
        [StringLengthSis(5, 20, "Username should be between 5 and 20 characters")]
        public string Username { get; set; }

        [RequiredSis]
        public string Password { get; set; }
    }
}
