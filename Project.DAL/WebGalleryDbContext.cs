using Project.DAL.Entities;
using Project.DAL.Mappings;
using System;
using System.Data.Entity;

namespace Project.DAL
{
    public class WebGalleryDbContext : DbContext, IDbContext
    {
        public WebGalleryDbContext() : base("name=WebGalleryDbConnectionString") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserEntityMap());
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<UserEntity> Users { get; set; }

    }
}
