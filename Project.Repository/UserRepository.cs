using Project.Repository.Common;
using System;
using System.Threading.Tasks;
using Project.Model.Common;
using AutoMapper;
using Project.DAL.Entities;

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
        public async Task<int> CreateAsync(IUser user)
        {
            user.UserId = Guid.NewGuid();
            var userEntity = Mapper.Map<IUser, UserEntity>(user);
            return await GenericRepository.AddAsync<UserEntity>(userEntity);
        }
        #endregion Methods

    }
}
