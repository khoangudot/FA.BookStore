using FA.BookStore.Core.UserInterface;
using System.Text;

namespace FA.BookStore.Core
{
    public class Program
    {
        static void Main(string[] args)
        {
			try
			{
                Console.OutputEncoding = Encoding.UTF8;
                MenuUI.MainMenu();
            }
			catch (Exception ex)
			{

                Console.WriteLine(ex.Message); 
			}
        }
    }
}