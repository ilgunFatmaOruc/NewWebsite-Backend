using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsWebSite.Domain
{
    public class Category:BaseEntity
    {
        public Category() //yeni ürünlerin eklenmesini sağlar....
        {
            this.Item = new List<Item>();
        }
       

        public string CategoryName { get; set; }

        public string CategoryDescription { get; set; }

        public virtual IEnumerable<Item> Item { get; set; } //lazyloading açık olsa da olmasa da relation ı yapıp getiriyor.
    }
}
