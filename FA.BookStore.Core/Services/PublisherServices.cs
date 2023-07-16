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
    internal class PublisherServices
    {
        internal static int GetPublisherOptionInput()
        {
            var publishers = PublisherRepository.GetAllPublishers();
            var publishersNameArray = publishers.Select(c => c.Name).ToArray();
            var option = AnsiConsole.Prompt(new SelectionPrompt<string>()
                .Title("\n-------Choose Publisher------")
                .AddChoices(publishersNameArray));
            var pubId = publishers.Single(p => p.Name == option).PubId;
            return pubId;
        }
        internal static void AddNewPublisher()
        {
            try
            {
                var publisher = new Publisher();
                publisher.Name = AnsiConsole.Ask<string>("Enter Publisher' name: ");
                publisher.Description = AnsiConsole.Ask<string>("Enter publisher description: ");
                PublisherRepository.AddNewPublisher(publisher);
                Console.WriteLine("Publisher added successfully!");
                Console.WriteLine("Press any key to  continue....");
                Console.ReadLine();
                Console.Clear();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Add Publisher Fail");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Press any key to  continue....");
                Console.ReadLine();
                Console.Clear();
            }
        }

        internal static void DeletePublisher()
        {
            try
            {
                var pubId = GetPublisherOptionInput();
                var publisher = PublisherRepository.GetPublisherById(pubId);
                PublisherRepository.DeletePublishery(publisher);
                Console.WriteLine("Publisher deleted successfully!");
                Console.WriteLine("Press any key to  continue....");
                Console.ReadLine();
                Console.Clear();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Delete Publisher  Fail");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Press any key to  continue....");
                Console.ReadLine();
                Console.Clear();
            }
        }

        internal static void GetAllPublishers()
        {
            var publishers = PublisherRepository.GetAllPublishers();
            PublisherUI.DisplayAllPublishers(publishers);
        }

        internal static void GetPublisher()
        {
            var pubId = GetPublisherOptionInput();
            var publisher = PublisherRepository.GetPublisherById(pubId);
            PublisherUI.DisplayPublisherInfo(publisher);
        }

        internal static void UpdatePublisher()
        {
            var pubId = GetPublisherOptionInput();
            var publisher = PublisherRepository.GetPublisherById(pubId);
            publisher.Name = AnsiConsole.Confirm("Do you want to update this publisher's name?")
                ? AnsiConsole.Ask<string>("Enter new name for this publisher: ")
                : publisher.Name;
            publisher.Description = AnsiConsole.Confirm("Do you want to update this publisher description?")
               ? AnsiConsole.Ask<string>("Description: ")
               : publisher.Description;
            try
            {
                PublisherRepository.UpdatePublisher(publisher);
                Console.WriteLine("Update Publisher successfull");
                Console.WriteLine("Press any key to continue....");
                Console.ReadLine();
                Console.Clear();
            }
            catch (Exception ex)
            {

                Console.WriteLine("Update Publishers fail");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Press any key to  continue....");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
