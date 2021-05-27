using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsWebSite.Domain
{
    public class Item:BaseEntity
    {
        public string NewsTitle { get; set; }

        public string NewsSubTitle { get; set; }

        public string NewsContent { get; set; }

        public bool IsPublishing { get; set; }

        public string NewsImage { get; set; }

        [ForeignKey("Category")] //has ile mapping kısmında da yapılabilir...
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
