using Project.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Service.Common
{
    public interface IUserService
    {
        /// <summary>
        /// Creates a new user asynchronously.
        /// </summary>
        /// <param name="user">User to be created.</param>
        /// <returns></returns>
        Task<int> CreateAsync(IUser user);
    }
}
