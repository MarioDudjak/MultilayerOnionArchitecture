using Project.Repository.Common;
using System;
using System.Threading.Tasks;
using Project.Model.Common;

namespace Project.Repository
{
    public class UserRepository: IUserRepository
    {

        #region Constructors
        public UserRepository()
        {
        }
        #endregion Constructors


        #region Methods

        /// <summary>
        /// Creates a new user.
        /// </summary>
        /// <param name="user">User which will be created.</param>
        /// <returns></returns>
        public Task<IUser> CreateAsync(IUser user)
        {
            throw new NotImplementedException();
        }
        #endregion Methods

    }
}
