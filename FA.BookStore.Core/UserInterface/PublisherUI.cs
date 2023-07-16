using FA.BookStore.Core.Models;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.BookStore.Core.UserInterface
{
    internal class PublisherUI
    {
        internal static void DisplayAllPublishers(List<Publisher> publishers)
        {
            var table = new Table();
            table.AddColumn("PubId");
            table.AddColumn("PubName");
            table.AddColumn("Description");
            foreach (var p in publishers)
            {
                table.AddRow(p.PubId.ToString(), p.Name,string.IsNullOrEmpty(p.Description)? "NULL": p.Description);
            }
            AnsiConsole.Write(table);
            Console.WriteLine("Press any key to continue......");
            Console.ReadLine();
            Console.Clear();
        }

        internal static void DisplayPublisherInfo(Publisher publisher)
        {
            
            var panel = new Panel($@"ID: {publisher.PubId} 
Name: {publisher.Name}
Description: {publisher.Description}");

            panel.Header = new PanelHeader($"{publisher.Name}");
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
