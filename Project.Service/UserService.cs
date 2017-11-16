using Project.Service.Common;
using System;
using System.Threading.Tasks;
using Project.Model.Common;
using Project.Repository.Common;

namespace Project.Service
{
    public class UserService : IUserService
    {
        #region Constructors

        public UserService(IUserRepository repository)
        {
            Repository = repository;
        }

        #endregion Constructors

        #region Properties

        protected IUserRepository Repository { get; private set; }

        #endregion Properties

        #region Methods
        public async Task<int> CreateAsync(IUser user)
        {
            return await Repository.CreateAsync(user);
        }

        #endregion Methods
    }
}
