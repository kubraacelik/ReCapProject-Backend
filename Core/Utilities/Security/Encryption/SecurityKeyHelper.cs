using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Encryption
{
    public class SecurityKeyHelper //şifreleri byte,array formatında oluşturmamız gerekiyor.
                                   //bunları asp.net,json ve token servislerinin anlayacağı hale getirmemiz gerekiyor
    {
        public static SecurityKey CreateSecurityKey(string securityKey) //WebApi'deki ayarlardaki(appsettings.json) securityKey'i oluşturuyoruz
        {
            return new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securityKey));
        }
    }
}
