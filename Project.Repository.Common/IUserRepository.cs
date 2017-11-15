using Project.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Repository.Common
{
    public interface IUserRepository
    {
        /// <summary>
        /// Creates a new user.
        /// </summary>
        /// <param name="user">User which will be created.</param>
        /// <returns></returns>
        Task<IUser> CreateAsync(IUser user);
    }
}
