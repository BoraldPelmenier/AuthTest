using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuthTest.Auth.Common
{
    public class AuthOptions
    {
        public string Issuer { get; set; } // кто сгинерировал 
        public string Audience { get; set; } // для кого токен был создан
        public string Secret { get; set; } 
        public int TokenLifeTime { get; set; } // время жизни токена

        public SymmetricSecurityKey GetSymmetricSecurityKey()
        {
            return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(Secret));
        }
    }
}
