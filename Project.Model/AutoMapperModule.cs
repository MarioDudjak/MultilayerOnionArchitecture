using AutoMapper;
using Ninject.Modules;
using Project.DAL.Entities;
using Project.Model.Common;

namespace Project.Model
{
    public class AutoMapperModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IMapper>().ToMethod(AutoMapper).InSingletonScope();
        }

        private IMapper AutoMapper(Ninject.Activation.IContext context)
        {
            Mapper.Initialize(config =>
            {
                config.CreateMap<UserEntity, UserPOCO>().ReverseMap();
                config.CreateMap<UserEntity, IUser>().ReverseMap();
                config.CreateMap<UserPOCO, IUser>().ReverseMap();

            });

            return Mapper.Instance;
        }
    
}
}
