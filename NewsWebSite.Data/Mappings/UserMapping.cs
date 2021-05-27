using NewsWebSite.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsWebSite.Data.Mappings
{
    public class UserMapping: EntityTypeConfiguration<User>
    {
        //public UserMapping()
        //{
        //    ToTable("User");
        //    Property(i => i.UserName).IsRequired();
        //    Property(i => i.UserPassword).IsRequired();
        //}
    }
}
