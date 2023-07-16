using FA.BookStore.Core.Models;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.BookStore.Core.UserInterface
{
    internal class CategoryUI
    {
        internal static void DisplayAllCategories(List<Category> categories)
        {
            var table = new Table();
            table.AddColumn("CategoryId");
            table.AddColumn("CategoryName");
            table.AddColumn("Description");
            foreach (Category p in categories)
            {
                table.AddRow(p.CateId.ToString(), p.CateName, string.IsNullOrEmpty(p.Description) ? "NULL" : p.Description);
            }
            AnsiConsole.Write(table);
            Console.WriteLine("Press any key to continue......");
            Console.ReadLine();
            Console.Clear();
        }

        internal static void DisplayCategoryInfo(Category category)
        {
            int totalQuantity = 0;
            foreach (var book in category.Books)
            {
                totalQuantity += book.Quantity;
            }

            int categoryTotalBook = category.Books.Count() * totalQuantity;
            var panel = new Panel($@"ID: {category.CateId} 
Name: {category.CateName}
Description: {category.Description}
Quantity in stock: {categoryTotalBook}");

            panel.Header = new PanelHeader($"{category.CateName}");
            panel.Header.Centered();

            panel.Padding = new Padding(2, 2, 2, 2);
            AnsiConsole.Write(panel);
            //DisplayAllProducts(category.Products);
            Console.WriteLine("Press any key to continue......");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
