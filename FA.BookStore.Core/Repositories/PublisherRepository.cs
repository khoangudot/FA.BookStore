using FA.BookStore.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace FA.BookStore.Core.Repositories
{
    internal class PublisherRepository
    {
        static BookStoreContext _Dbcontext = new BookStoreContext();
        internal static void AddNewPublisher(Publisher publisher)
        {
            _Dbcontext.Publishers.Add(publisher);
            _Dbcontext.SaveChanges();
        }

        internal static void DeletePublishery(Publisher publisher)
        {
            _Dbcontext.Publishers.Remove(publisher);
            _Dbcontext.SaveChanges();
        }

        internal static List<Publisher> GetAllPublishers()
        {
            var publishers = _Dbcontext.Publishers.Include(p => p.Books).ToList();
            return publishers;
        }

        internal static Publisher GetPublisherById(int pubId)
        {
            var publisher = _Dbcontext.Publishers.FirstOrDefault(p=> p.PubId == pubId);
            return publisher;
        }

        internal static void UpdatePublisher(Publisher publisher)
        {
            _Dbcontext.Update(publisher);
            _Dbcontext.SaveChanges();
        }
    }
}
