using NewsWebSite.Contract.ViewModels;
using NewsWebSite.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsWebSite.Contract.Extentions
{
    public static class ItemExtentions
    {
        public static Item GetItem(this VmRegisterItem vmRegisterItem)
        {
            var item = new Item()
            {

                NewsTitle=vmRegisterItem.NewsTitle,
                NewsContent=vmRegisterItem.NewsContent,
                NewsImage=vmRegisterItem.NewsImage,
                CategoryId=vmRegisterItem.CategoryId, 
                CreatedTime = DateTime.Now,
                OnModifiedTime = DateTime.Now,
                IsActivated = true,
               
            };
            return item;
        }
    }
}
