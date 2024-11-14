using KretaBasicSchoolSystem.Desktop.Models;
using System;
using System.Net;

namespace KretaBasicSchoolSystem.Desktop.Repositories
{
    public class UserRepository
    {
        public bool AuthenticateUser(NetworkCredential credential)
        {
            bool validUser = true;
            return validUser;
        }

        public User? GetByUsername(string userName)
        {
             return new User
             {
                 Username = "user",
                 Email = "user.mail@gmail.com",
                 FirstName = "István",
                 LastName = "User",
                 Password = "pass111"
             };
        }
    }
}
