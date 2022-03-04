using PeopleAndBooks.DAL.Model;

namespace PeopleAndBooks.DAL.Interface
{
    public interface IBookRepository
    {
        int Add(BookDto book);
        void Delete(int id);
        List<BookDto> GetAll();
        List<BookDto> GetByAuthorId(int id);
    }
}