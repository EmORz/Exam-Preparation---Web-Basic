using System.Collections.Generic;
using Panda.Data_1.Models;

namespace Panda.Services_1
{
    public interface IUserService
    {
        string CreateUser(string username, string email, string password);

        IEnumerable<string> GetUsernames();

        User GetUsersOrNull(string username, string password);


    }
}