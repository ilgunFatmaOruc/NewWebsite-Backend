using NewsWebSite.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsWebSite.Data.Mappings
{
    public class CategoryMapping :EntityTypeConfiguration<Category>
    {
        public CategoryMapping()
        {
            ToTable("Category");
            Property(i => i.CategoryName).IsRequired();
            
        }
    }
}
