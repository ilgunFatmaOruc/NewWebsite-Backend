using NewsWebSite.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsWebSite.Data.Mappings
{
    public class ItemMapping : EntityTypeConfiguration<Item>
    {
        public ItemMapping()
        {
            ToTable("Item");
            Property(i => i.NewsTitle).IsRequired();
            Property(i => i.NewsContent).IsRequired();
            Property(i => i.CategoryId).IsRequired();
            //HasRequired(i => i.Category);

        }
    }
}
