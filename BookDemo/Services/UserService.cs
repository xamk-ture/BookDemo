﻿using BookDemo.Interface;
using BookDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookDemo.Services
{
    public class UserService : Interface.IUserService
    {
        private List<User> _users = new List<User>();

        public bool RemoveUser(int userId)
        {
            User userToRemove = _users.FirstOrDefault(u => u.Id == userId);

            if(userToRemove == null)
            {
                return false;
            }

            _users.Remove(userToRemove);

            return true;
        }

        public bool UpdateUser(User user)
        {
            User userToUpdate = _users.FirstOrDefault(u => u.Id == user.Id);

            if(userToUpdate == null)
            {
                return false;
            }   

            userToUpdate.Name = user.Name;
            userToUpdate.Email = user.Email;
            userToUpdate.Password = user.Password;

            return true;
        }

        public bool AddUser(User user)
        {
            _users.Add(user);

            return true;
        }
    }
}
