using System;
using Project.Model.Common;

namespace Project.Model
{
    public class UserPOCO : IUser
    {
        public Guid UserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
