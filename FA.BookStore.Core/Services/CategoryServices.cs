using FA.BookStore.Core.Models;
using FA.BookStore.Core.Repositories;
using FA.BookStore.Core.UserInterface;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.BookStore.Core.Services
{
    internal class CategoryServices
    {
       
        internal static int GetCategoryOptionInput()
        {
            var categories = CategoryRepository.GetAllCategories();
            var categoriesNameArray = categories.Select(c => c.CateName).ToArray();
            var option = AnsiConsole.Prompt(new SelectionPrompt<string>()
                .Title("\n-------Choose Category------")
                .AddChoices(categoriesNameArray));
            var CategoryId = categories.Single(p => p.CateName == option).CateId;
            return CategoryId;
        }
        internal static void AddNewCategory()
        {
            try
            {
                var category = new Category();
                category.CateName = AnsiConsole.Ask<string>("Enter category' name: ");
                category.Description = AnsiConsole.Ask<string>("Enter category description: ");
                CategoryRepository.AddNewCategory(category);
                Console.WriteLine("Category added successfully!");
                Console.WriteLine("Press any key to  continue....");
                Console.ReadLine();
                Console.Clear();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Add Category Fail");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Press any key to  continue....");
                Console.ReadLine();
                Console.Clear();
            }
        }


        internal static void DeleteCategory()
        {
            try
            {
                var cateId = GetCategoryOptionInput();
                var category = CategoryRepository.GetCategoryById(cateId);
                CategoryRepository.DeleteCategory(category);
                Console.WriteLine("Category deleted successfully!");
                Console.WriteLine("Press any key to  continue....");
                Console.ReadLine();
                Console.Clear();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Delete Category  Fail");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Press any key to  continue....");
                Console.ReadLine();
                Console.Clear();
            }

        }

        internal static void GetAllCategories()
        {
            var categories = CategoryRepository.GetAllCategories();
            CategoryUI.DisplayAllCategories(categories);
        }

        internal static void GetCategory()
        {
            var categoryId = GetCategoryOptionInput();
            var category = CategoryRepository.GetCategoryById(categoryId);
            CategoryUI.DisplayCategoryInfo(category);
        }

        internal static void UpdateCategory()
        {
            var categoryId = GetCategoryOptionInput();
            var category = CategoryRepository.GetCategoryById(categoryId);
            category.CateName = AnsiConsole.Confirm("Do you want to update this categoy name?")
                ? AnsiConsole.Ask<string>("Enter new name for this Cateory: ")
                : category.CateName;
            category.Description = AnsiConsole.Confirm("Do you want to update this categoy description?")
               ? AnsiConsole.Ask<string>("Description: ")
               : category.Description;
            try
            {
                CategoryRepository.UpdateCategory(category);
                Console.WriteLine("Update Category successfull");
                Console.WriteLine("Press any key to continue....");
                Console.ReadLine();
                Console.Clear();
            }
            catch (Exception ex)
            {

                Console.WriteLine("Update Category fail");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Press any key to  continue....");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
