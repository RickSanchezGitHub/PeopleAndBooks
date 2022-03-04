using PeopleAndBooks.BLL.Model;

namespace PeopleAndBooks.BLL.Service.Interface
{
    public interface IBookService
    {
        int Add(Book book);
        void Delete(int id);
        List<Book> GetAll();
        List<Book> GetBooksByAuthorId(int id);
    }
}