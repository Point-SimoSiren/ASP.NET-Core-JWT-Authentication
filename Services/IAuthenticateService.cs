using CoreKirjautuminen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreKirjautuminen.Services
{
    public interface IAuthenticateService
    {
        User Authenticate(string userName, string password);
    }
}
