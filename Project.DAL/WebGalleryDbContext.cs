using Project.DAL.Entities;
using Project.DAL.Mappings;
using System;
using System.Data.Entity;

namespace Project.DAL
{
    public class WebGalleryDbContext : DbContext, IDbContext
    {
        public WebGalleryDbContext() : base("name=WebGalleryDbConnectionString") { }

        public static WebGalleryDbContext Create()
        {
            return new WebGalleryDbContext();
        }

        public DbSet<UserEntity> Users { get; set; }
       

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserEntityMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
