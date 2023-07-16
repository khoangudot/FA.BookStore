using FA.BookStore.Core.Repositories;
using FA.BookStore.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.BookStore.Core.UserInterface
{
    internal class MenuUI
    {

        internal static void MainMenu()
        {
            Console.Clear();
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Welcome to FA Book Store!");
            Console.ResetColor();
            Console.WriteLine("\nUse ⬆️  and ⬇️  to navigate and press \u001b[32mEnter/Return\u001b[0m to select:");
            (int left, int top) = Console.GetCursorPosition();
            var option = 0;
            var decorator = "✅ \u001b[32m";
            ConsoleKeyInfo key;

            var selectedOption = false;
                while (!selectedOption)
                {
                    Console.SetCursorPosition(left, top);

                    Console.WriteLine($"{(option == 1 ? decorator : "   ")}1- Manage Book\u001b[0m");
                    Console.WriteLine($"{(option == 2 ? decorator : "   ")}2- Manage Category\u001b[0m");
                    Console.WriteLine($"{(option == 3 ? decorator : "   ")}3- Manage Publisher\u001b[0m");
                    Console.WriteLine($"{(option == 4 ? decorator : "   ")}4- Manage Comment\u001b[0m");
                    Console.WriteLine($"{(option == 5 ? decorator : "   ")}5- Exit\u001b[0m");
                    key = Console.ReadKey(false);

                    switch (key.Key)
                    {
                        case ConsoleKey.UpArrow:
                            option = option == 1 ? 5 : option - 1;
                            break;

                        case ConsoleKey.DownArrow:
                            option = option == 5 ? 1 : option + 1;
                            break;

                        case ConsoleKey.Enter:
                            selectedOption = true;
                            break;
                    }
                }

                switch (option)
                {
                    case 1:
                        ManageBookMenu();
                        break;
                    case 2:
                        ManageCategoryMenu();
                        break;
                    case 3:
                        ManagePublisherMenu();
                        break;
                    case 4:
                        Console.WriteLine("case4");
                        break;
                    case 5:
                    Console.WriteLine("Good Bye");
                        break;
                    default:
                        Console.WriteLine();
                        break;
                }
            }
        internal static void ManageBookMenu()
        {
            Console.Clear();
            Console.WriteLine("Manage Book!");
            Console.ResetColor();
            Console.WriteLine("\nUse ⬆️  and ⬇️  to navigate and press \u001b[32mEnter/Return\u001b[0m to select:");
            (int left, int top) = Console.GetCursorPosition();
            var option = 1;
            var decorator = "✅ \u001b[32m";
            ConsoleKeyInfo key;

            var selectedOption = false;
            var isManageBookRunning = true;

            while (isManageBookRunning)
            {
                while (!selectedOption)
                {
                    Console.SetCursorPosition(left, top);

                    Console.WriteLine($"{(option == 1 ? decorator : "   ")}1- Add a new book\u001b[0m");
                    Console.WriteLine($"{(option == 2 ? decorator : "   ")}2- Find book by BookID\u001b[0m");
                    Console.WriteLine($"{(option == 3 ? decorator : "   ")}3- Update Book\u001b[0m");
                    Console.WriteLine($"{(option == 4 ? decorator : "   ")}4- Delete Book\u001b[0m");
                    Console.WriteLine($"{(option == 5 ? decorator : "   ")}5- Show all book in store\u001b[0m");
                    Console.WriteLine($"{(option == 6 ? decorator : "   ")}6- Find book by title\u001b[0m");
                    Console.WriteLine($"{(option == 7 ? decorator : "   ")}7- Find Book By Summary\u001b[0m");
                    Console.WriteLine($"{(option == 8 ? decorator : "   ")}8- Get Latest Book\u001b[0m");
                    Console.WriteLine($"{(option == 9 ? decorator : "   ")}9- Get Books By Month\u001b[0m");
                    Console.WriteLine($"{(option == 10 ? decorator : "   ")}10- Count Books For Category\u001b[0m");
                    Console.WriteLine($"{(option == 11 ? decorator : "   ")}11- Get Books By Category\u001b[0m");
                    Console.WriteLine($"{(option == 12 ? decorator : "   ")}12- Count Books For Publisher\u001b[0m");
                    Console.WriteLine($"{(option == 13 ? decorator : "   ")}12- Get Books By Publisher\u001b[0m");
                    Console.WriteLine($"{(option == 14 ? decorator : "   ")} Back to main menu\u001b[0m");
                    key = Console.ReadKey(false);

                    switch (key.Key)
                    {
                        case ConsoleKey.UpArrow:
                            option = option == 1 ? 14 : option - 1;
                            break;

                        case ConsoleKey.DownArrow:
                            option = option == 14 ? 1 : option + 1;
                            break;

                        case ConsoleKey.Enter:
                            selectedOption = true;
                            break;
                    }
                }

                switch (option)
                {
                    case 1:
                        ManageBookMenu();
                        break;
                    case 2:
                        Console.WriteLine("case2");
                        break;
                    case 3:
                        Console.WriteLine("case3");
                        break;
                    case 4:
                        Console.WriteLine("case4");
                        break;
                    case 5:
                        isManageBookRunning = false;
                        MainMenu();
                        break;
                    default:
                        Console.WriteLine();
                        break;
                }

                selectedOption = false;
            }
        }
        internal static void ManageCategoryMenu()
        {
            Console.Clear();
            Console.WriteLine("Manage Category!");
            Console.ResetColor();
            Console.WriteLine("\nUse ⬆️  and ⬇️  to navigate and press \u001b[32mEnter/Return\u001b[0m to select:");
            (int left, int top) = Console.GetCursorPosition();
            var option = 1;
            var decorator = "✅ \u001b[32m";
            ConsoleKeyInfo key;

            var selectedOption = false;
            var isManageCategoryRunning = true;

            while (isManageCategoryRunning)
            {
                while (!selectedOption)
                {
                    Console.SetCursorPosition(left, top);

                    Console.WriteLine($"{(option == 1 ? decorator : "   ")}1- Add a new Category\u001b[0m");
                    Console.WriteLine($"{(option == 2 ? decorator : "   ")}2- Show Information' Category\u001b[0m");
                    Console.WriteLine($"{(option == 3 ? decorator : "   ")}3- Update Category\u001b[0m");
                    Console.WriteLine($"{(option == 4 ? decorator : "   ")}4- Show All Category\u001b[0m");
                    Console.WriteLine($"{(option == 5 ? decorator : "   ")}5- Delete Category\u001b[0m");
                    Console.WriteLine($"{(option == 6 ? decorator : "   ")}   Back to main menu\u001b[0m");
                    key = Console.ReadKey(false);

                    switch (key.Key)
                    {
                        case ConsoleKey.UpArrow:
                            option = option == 1 ? 6 : option - 1;
                            break;

                        case ConsoleKey.DownArrow:
                            option = option == 6 ? 1 : option + 1;
                            break;

                        case ConsoleKey.Enter:
                            selectedOption = true;
                            break;
                    }
                }

                switch (option)
                {
                    case 1:
                        CategoryServices.AddNewCategory();
                        break;
                    case 2:
                        CategoryServices.GetCategory();
                        break;
                    case 3:
                        CategoryServices.UpdateCategory();
                        break;
                    case 4:
                        CategoryServices.GetAllCategories();
                        break;
                    case 5:
                        CategoryServices.DeleteCategory();
                        break;
                    case 6:
                        isManageCategoryRunning = false;
                        MainMenu();
                        break;
                    default:
                        Console.WriteLine();

                        break;
                }

                selectedOption = false;
            }
        }
        internal static void ManagePublisherMenu()
        {
            Console.Clear();
            Console.WriteLine("Manage Publisher!");
            Console.ResetColor();
            Console.WriteLine("\nUse ⬆️  and ⬇️  to navigate and press \u001b[32mEnter/Return\u001b[0m to select:");
            (int left, int top) = Console.GetCursorPosition();
            var option = 1;
            var decorator = "✅ \u001b[32m";
            ConsoleKeyInfo key;

            var selectedOption = false;
            var isManagePublisherRunning = true;

            while (isManagePublisherRunning)
            {
                while (!selectedOption)
                {
                    Console.SetCursorPosition(left, top);

                    Console.WriteLine($"{(option == 1 ? decorator : "   ")}1- Add a new Publisher\u001b[0m");
                    Console.WriteLine($"{(option == 2 ? decorator : "   ")}2- Show Information' Publisher\u001b[0m");
                    Console.WriteLine($"{(option == 3 ? decorator : "   ")}3- Update Publisher\u001b[0m");
                    Console.WriteLine($"{(option == 4 ? decorator : "   ")}4- Show All Publisher\u001b[0m");
                    Console.WriteLine($"{(option == 5 ? decorator : "   ")}5- Delete Publisher\u001b[0m");
                    Console.WriteLine($"{(option == 6 ? decorator : "   ")}   Back to main menu\u001b[0m");
                    key = Console.ReadKey(false);

                    switch (key.Key)
                    {
                        case ConsoleKey.UpArrow:
                            option = option == 1 ? 6 : option - 1;
                            break;

                        case ConsoleKey.DownArrow:
                            option = option == 6 ? 1 : option + 1;
                            break;

                        case ConsoleKey.Enter:
                            selectedOption = true;
                            break;
                    }
                }

                switch (option)
                {
                    case 1:
                        PublisherServices.AddNewPublisher();
                        break;
                    case 2:
                        PublisherServices.GetPublisher();
                        break;
                    case 3:
                        PublisherServices.UpdatePublisher();
                        break;
                    case 4:
                        PublisherServices.GetAllPublishers();
                        break;
                    case 5:
                        PublisherServices.DeletePublisher();
                        break;
                    case 6:
                        isManagePublisherRunning = false;
                        MainMenu();
                        break;
                    default:
                        Console.WriteLine();
                        break;
                }

                selectedOption = false;
            }
        }
    }
}
