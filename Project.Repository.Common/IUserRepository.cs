using Project.Model.Common;
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
        Task<int> CreateAsync(IUser user);
    }
}
