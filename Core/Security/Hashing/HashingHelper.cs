using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Hashing
{
    public class HashingHelper
    {
        public static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt) //ona verdiğimiz string password'un hash'ini ve salt'ını oluşturacak 
                                                                                                                 //out byte[] passwordHash, out byte[] passwordSalt =dışarıya verilecek değer
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key; //her kullanıcı için farklı key oluşturur
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }

        public static bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt) ////passwordHash'ini doğrula demek ,out olmayacak çünkü değerleri biz vereceğiz
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt)) //doğrulama yapmak için key anahtarını istiyor o da passwordSalt
            {
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != passwordHash[i])
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
