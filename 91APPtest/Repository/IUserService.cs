using _91APPtest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _91APPtest.Repository
{
    public interface IUserService
    {
        bool IsValid(LoginRequestDTO req);
    }
}
