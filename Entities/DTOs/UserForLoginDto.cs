using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class UserForLoginDto : IDto //sistemimize giriş yapmak için
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
