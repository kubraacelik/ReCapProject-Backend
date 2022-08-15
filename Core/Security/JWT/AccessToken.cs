using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.JWT
{
    public class AccessToken //erişim anahtarı 
    {
        public string Token { get; set; } //anlamsız karakterlerden oluşan anahtar değeridir
        public DateTime Expiration { get; set; } //token'in bitiş süresi
    }
}
