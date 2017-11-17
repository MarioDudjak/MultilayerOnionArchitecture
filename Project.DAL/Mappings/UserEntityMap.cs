using Project.DAL.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Project.DAL.Mappings
{
    public class UserEntityMap : EntityTypeConfiguration<UserEntity>
    {
        public UserEntityMap()
        {
            // key
            HasKey(entity => entity.UserId);
            Property(entity => entity.UserId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            //properties
            Property(entity => entity.Username).IsRequired();
            Property(entity => entity.Email).IsRequired();
            Property(entity => entity.Password).IsRequired();

            //table
            ToTable("Users");

        }
    }
}
