namespace Project.DAL
{
    public class DIModule : Ninject.Modules.NinjectModule
    {
        public override void Load()
        {
           
            Bind<IDbContext>().To<WebGalleryDbContext>();

        }
    }
}
