using System;
using System.Data.Entity;

namespace Project.DAL
{
    public class WebGalleryDbContext : DbContext, IDbContext
    {
        public WebGalleryDbContext() : base("name=WebGalleryDbConnectionString") { }
       
    }
}
