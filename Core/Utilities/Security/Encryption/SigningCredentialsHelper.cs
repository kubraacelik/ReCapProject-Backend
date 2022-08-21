using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Encryption
{
    public class SigningCredentialsHelper //Credential=kullanıcı bilgileri
    {
        public static SigningCredentials CreateSigningCredentials(SecurityKey securityKey) //şifremizin imzalanmasını döndürecek
        {
            return new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha512Signature); //hashing için anahtar olarak securityKey'i,
                                                                                                //şifreleme olarakta Güvenlik algoritmalarından HmacSha512'yi kullan
        }
    }
}
