using Project.Repository.Common;
using System;
using System.Threading.Tasks;
using Project.Model.Common;
using AutoMapper;

namespace Project.Repository
{
    public class UserRepository: IUserRepository
    {

        #region Constructors
        public UserRepository(IGenericRepository genericRepository, IMapper mapper)
        {
            GenericRepository = genericRepository;
            Mapper = mapper;
        }
        #endregion Constructors

        #region Properties
        protected IGenericRepository GenericRepository { get; private set; }
        #endregion Properties

        #region Fields
        private readonly IMapper Mapper;
        #endregion Fields

        #region Methods

        /// <summary>
        /// Creates a new user.
        /// </summary>
        /// <param name="user">User which will be created.</param>
        /// <returns></returns>
        public async Task<IUser> CreateAsync(IUser user)
        {
            user.UserId = Guid.NewGuid();
            var userEntity = Mapper.Map<IUser, UserEntity>(user);

            var result = await GenericRepository.CreateAsync<UserEntity>(userEntity);

            return Mapper.Map<UserEntity, IUser>(result);
        }
        #endregion Methods

    }
}
