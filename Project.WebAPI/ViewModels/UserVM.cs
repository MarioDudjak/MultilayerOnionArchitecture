using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.WebAPI.ViewModels
{
    public class UserVM
    {
        public Guid UserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }


    }
}