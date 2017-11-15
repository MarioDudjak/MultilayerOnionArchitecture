using AutoMapper;
using Project.Model.Common;
using Project.Service.Common;
using Project.WebAPI.ViewModels;
using System.Threading.Tasks;
using System.Web.Http;

namespace Project.WebAPI.Controllers
{
    [RoutePrefix("api/user")]
    public class UserController : ApiController
    {

        #region Constructors
    
        public UserController(IUserService userService, IMapper mapper)
        {
            UserService = userService;
            Mapper = mapper;
        }

        #endregion Constructors

        #region Properties

        protected IUserService UserService { get; private set; }
        private readonly IMapper Mapper;

        #endregion Properties

        #region Methods
       
        // POST: api/User/create
        [HttpPost]
        [Route("create")]
        public async Task<IHttpActionResult> Post(UserVM user)
        { 
            var newUser = await UserService.CreateAsync(Mapper.Map<UserVM, IUser>(user));
            if (newUser != null)
            {
                return Created<IUser>(Request.RequestUri + newUser.UserId.ToString(), newUser);
            }
            else
            {
                return Conflict();
            }
        }
        #endregion Methods

    }
}
