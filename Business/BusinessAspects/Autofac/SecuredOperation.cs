using Core.Utilities.Interceptors;
using Core.Utilities.IoC;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using Castle.DynamicProxy;
using Microsoft.Extensions.DependencyInjection;
using Business.Constants;
using Core.Extensions;

namespace Business.BusinessAspects.Autofac
{
    public class SecuredOperation : MethodInterception
    {
        private string[] _roles;
        private IHttpContextAccessor _httpContextAccessor; //giriş yapan herkes için bir httpcontext oluşur ki karışmasın

        public SecuredOperation(string roles)
        {
            _roles = roles.Split(','); //Attribute olarak yazdığım SecuredOperation'a virgülle yazabilirim demek
            _httpContextAccessor = ServiceTool.ServiceProvider.GetService<IHttpContextAccessor>();

        }

        protected override void OnBefore(IInvocation invocation) //metodun önünde çalıştır demek
        {
            var roleClaims = _httpContextAccessor.HttpContext.User.ClaimRoles(); //kullanıcının claimroles'ini bul
            foreach (var role in _roles)                                         //bu kullanıcının rollerini gez
            {
                if (roleClaims.Contains(role))  //eğer claims'lerin içinde ilgili rol varsa metodu çalıştırmaya devam et
                {
                    return;
                }
            }
            throw new Exception(Messages.AuthorizationDenied); //eğer yoksa "yetkin yok" hatası ver
        }
    }
}
