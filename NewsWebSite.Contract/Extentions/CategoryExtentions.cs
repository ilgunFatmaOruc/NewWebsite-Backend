using NewsWebSite.Contract.ViewModels;
using NewsWebSite.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsWebSite.Contract.Extentions
{
    public static class CategoryExtentions
    {
        public static Category GetCategory(this VmRegisterCategory vmRegisterCategory)
        {
            var category = new Category()
            {

                CategoryName = vmRegisterCategory.CategoryName,
                CategoryDescription=vmRegisterCategory.CategoryDescription,
                CreatedTime = DateTime.Now,
                OnModifiedTime = DateTime.Now,
                IsActivated = true,
               
            };
            return category;
        }
    }
}
