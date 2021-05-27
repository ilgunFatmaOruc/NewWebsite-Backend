using NewsWebSite.Contract.Extentions;
using NewsWebSite.Contract.ViewModels;
using NewsWebSite.Data;
using NewsWebSite.Domain;
using NewsWebSite.Services.Common;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsWebSite.Services
{
    public class ItemService
    {
        private DatabaseContext database;

        public ItemService()
        {
            database = ContextManagment.GetContext();
        }


        public bool IsValidItemNewsTitle(string newsTitle)
        {
            var checkNewsTitle = database.Item.FirstOrDefault(i => (i.NewsTitle.Equals(newsTitle)) || (i.NewsTitle.Equals(newsTitle)));
        
            return checkNewsTitle == null ? true : false;
        }

        public void AddItem(Item item)
        {
            if (item == null)
                throw new System.NullReferenceException(nameof(Item));
            database.Item.Add(item);
        }

        public void EditItem(Item item)
        {
            if (item == null)
                throw new System.NullReferenceException(nameof(Item));
            database.Entry(item).State = EntityState.Modified;
        }

        public void DeleteItem(int id)
        {
            if (id <= 0)
                throw new System.NullReferenceException("id boş olamaz");
            var item = GetItem(id);
            database.Item.Remove(item);
        }

        public void AddRegisterItem(VmRegisterItem vmItem)
        {
            if (vmItem == null)
                throw new System.NullReferenceException("kayıt edilecek bilgi bulunamadı");
            var tempItem = vmItem.GetItem();
            database.Item.Add(tempItem);
        }

        public List<Item> GetItem()
        {
            var itemList = database.Item.ToList();
            return itemList;
        }

        public Item GetItem(int id)
        {
            if (id <= 0)
                throw new System.NullReferenceException("id boş olamaz");
            var itemListForId = database.Item.FirstOrDefault(i => i.Id == id);
            return itemListForId;
        }

        public int SaveDb()
        {
            return ContextManagment.Save();
        }

        public void Disposing()
        {
            ContextManagment.Disposing();
        }
    }
}
