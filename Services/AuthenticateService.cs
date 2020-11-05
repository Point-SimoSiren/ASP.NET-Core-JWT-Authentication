using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt; // <<----- lisätty itse -----<<
using CoreKirjautuminen.Models; // <<----- lisätty itse -----<<
using System.Linq;
using System.Text; // <<----- lisätty itse -----<<
using System.Threading.Tasks;
using Microsoft.Extensions.Options;

namespace CoreKirjautuminen.Services
{
    public class AuthenticateService : IAuthenticateService
    {
        private readonly AppSettings _appSettings;
        public AuthenticateService(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
        }


        // Tämä kuvastaa tietokantayhteyttä NorthwindContext context = new NorthwindContext();
        // viittaus tähän olisi context.users, mutta nyt on pelkkä users.

        private List<User> users = new List<User>()
        {
            new User  {UserId = 1, FirstName = "Simo", LastName = "Siili", UserName = "simosiili",
            Password = "Siili123"}
        };

        public User Authenticate(string userName, string password)
        {
           
            var user = users.SingleOrDefault(x => x.UserName == userName && x.Password == password);

            // Jos ei käyttäjää löydy palautetaan null
            if (user == null)
            {
                return null;
            }

            // Jos löytyy:
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Key);

        }

    }
}
