using BookDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookDemo.Services
{
    public class UserLocalFileService : Interface.IUserService
    {
        public bool AddUser(User user)
        {
            Console.WriteLine(user.Name);

            return true;
        }

        public bool RemoveUser(int userId)
        {
            throw new NotImplementedException();
        }

        public bool UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
