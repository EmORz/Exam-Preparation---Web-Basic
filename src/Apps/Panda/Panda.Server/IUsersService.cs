using System.Collections.Generic;
using Panda.Data.Models;

namespace Panda.Service
{
    public interface IUsersService
    {
        string CreateUser(string email, string password, string username);

        User GetUserOrNull(string username, string password);

        IEnumerable<string> GetUsers();
    }
}