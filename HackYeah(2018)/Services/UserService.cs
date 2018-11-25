using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HackYeah_2018_.Interfaces;
using HackYeah_2018_.Models;

namespace HackYeah_2018_.Services
{
    public class UserService : IUserService
    {
        private readonly HackContext _context;

        public UserService(HackContext context)
        {
            _context = context;
        }
        public User GetUser()
        { 
            //TODO
            var user = _context.Users;

            if (user == null)
            {
                return null;
            }

            return null;
        }

        public User GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        public User CreateUser(User createUser)
        {
            throw new NotImplementedException();
        }
    }
}
