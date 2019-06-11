using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Panda.Data;
using Panda.Data.Models;

namespace Panda.Service
{
    public class UsersService : IUsersService
    {
        private readonly PandaDbContext db;

        public UsersService(PandaDbContext db)
        {
            this.db = db;
        }

        public string CreateUser(string email, string password, string username)
        {
            var user = new User
            {
                Username = username,
                Email = email,
                Password = this.HashPassword(password),
            };
            this.db.Users.Add(user);
            this.db.SaveChanges();
            return user.Id;
        }

        public User GetUserOrNull(string username, string password)
        {
            var hashPass = this.HashPassword(password);
            var user = db.Users.FirstOrDefault(x => x.Username == username && x.Password == hashPass);
            return user;
        }

        public IEnumerable<string> GetUsers()
        {
            var users = this.db.Users.Select(x => x.Username).ToList();
            return users;
        }


        private string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                return Encoding.UTF8.GetString(sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password)));
            }
        }
    }
}