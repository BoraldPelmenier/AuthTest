using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthTest.Auth.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuthTest.Auth.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private List<Account> Accounts => new List<Account>
        {
            new Account()
            {
                Id = Guid.Parse("e2371dc9-a849-4f3c-9004-df8fc921c123a"),
                Email = "user@email.com",
                Password = "user",
                Roles = new Role[] {Role.User}
            },
            new Account()
            {
                Id = Guid.Parse("3r23ew39-4329-4f3c-921h-d41fere2wv23a"),
                Email = "user2@email.com",
                Password = "user2",
                Roles = new Role[] {Role.User}
            },
            new Account()
            {
                Id = Guid.Parse("e2371dc9-a849-4f3c-9004-d4jf3jt63f3a"),
                Email = "admin@email.com",
                Password = "admin",
                Roles = new Role[] {Role.Admin}
            }

        };

        [Route("login")]
        [HttpPost]
        public IActionResult Login([FromBody]Login request)
        {
            var user = AuthenticateUser(request.Email, request.Password);

            if (user != null)
            {
                // Generate JWT
            }

            return Unauthorized();
        }

        public Account AuthenticateUser(string email, string password)
        {
            return Accounts.SingleOrDefault(u => u.Email == email && u.Password == password);
        }
    }
}