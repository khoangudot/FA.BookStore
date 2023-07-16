using FA.BookStore.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.BookStore.Core.Repositories
{
    internal class CategoryRepository
    {
        static BookStoreContext _Dbcontext = new BookStoreContext();
        internal static void AddNewCategory(Category category)
        {
            _Dbcontext.Categories.Add(category);
            _Dbcontext.SaveChanges();
        }

        internal static void DeleteCategory(Category category)
        {
            _Dbcontext.Categories.Remove(category);
            _Dbcontext.SaveChanges();
        }

        internal static List<Category> GetAllCategories()
        {
            var categories = _Dbcontext.Categories.Include(p => p.Books).ToList();
            return categories;
        }

        internal static Category GetCategoryById(int cateId)
        {
            var category = _Dbcontext.Categories.FirstOrDefault(c => c.CateId == cateId);
            return category;
        }

        internal static void UpdateCategory(Category category)
        {
            _Dbcontext.Update(category);
            _Dbcontext.SaveChanges();
        }
    }
}
