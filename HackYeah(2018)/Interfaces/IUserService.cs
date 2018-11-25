using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HackYeah_2018_.Models;

namespace HackYeah_2018_.Interfaces
{
    public interface IUserService
    {
        // w przyszłości możliwość rozbudowy o inne metody
        User GetUser();

        User GetUserById(int id);

        User CreateUser(User createUser);

    }
}
