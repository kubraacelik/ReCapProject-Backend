using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.JWT
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims); //token üretecek mekanizma
                                                                                  //kullanıcı adı,şifre girdikten sonra burası çalışacak
                                                                                  //eğer doğruysa ilgili kullanıcı için(user) veritabanına gidecek
                                                                                  //kullanıcın claim'lerini bulacak JWT üretecek ve doğrulayacak
    }
}

