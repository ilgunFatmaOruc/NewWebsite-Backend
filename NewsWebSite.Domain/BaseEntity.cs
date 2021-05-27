using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace NewsWebSite.Domain
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }

        public bool IsActivated { get; set; }

        public DateTime? CreatedTime { get; set; }
        

        public DateTime? OnModifiedTime { get; set; }
    }
}
