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
    public class CategoryService
    {
        private DatabaseContext database;

        public CategoryService()
        {
            database = ContextManagment.GetContext();
        }

        public bool IsValidCategoryname(string categoryName)
        {
            var checkCategoryName = database.Category.FirstOrDefault(i => (i.CategoryName.Equals(categoryName)) || (i.CategoryName.Equals(categoryName)));
            //return checkUser == null;
            return checkCategoryName == null ? true : false;
        }

        public void AddCategory(Category category)
        {
            if (category == null)
                throw new System.NullReferenceException(nameof(Category));
            database.Category.Add(category);
        }

        public void EditCategory(Category category)
        {
            if (category == null)
                throw new System.NullReferenceException(nameof(Category));
            database.Entry(category).State = EntityState.Modified;
        }

        public void DeleteCategory(int id)
        {
            if (id <= 0)
                throw new System.NullReferenceException("id boş olamaz");
            var categoryId = GetCategory(id);
            database.Category.Remove(categoryId);
        }

        public void AddRegisterCategory(VmRegisterCategory vmCategory)
        {
            if (vmCategory == null)
                throw new System.NullReferenceException("kayıt edilecek bilgi bulunamadı");
            var tempCategory = vmCategory.GetCategory();
            database.Category.Add(tempCategory);
        }

        public List<Category> GetCategory()
        {
            var categoryList = database.Category.ToList();
            return categoryList;
        }

        public Category GetCategory(int id)
        {
            if (id <= 0)
                throw new System.NullReferenceException("id boş olamaz");
            var category = database.Category.FirstOrDefault(i => i.Id == id);
            return category;
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
