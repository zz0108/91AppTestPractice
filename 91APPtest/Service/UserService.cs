using _91APPtest.Models;
using _91APPtest.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _91APPtest.Service
{
    public class UserService : IUserService
    {
        public bool IsValid(LoginRequestDTO req)
        {
            return true;
        }
    }
}
