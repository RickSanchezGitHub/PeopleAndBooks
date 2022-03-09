using PeopleAndBooks.DAL.Entity;

namespace PeopleAndBooks.DAL.Repository.Interface
{
    public interface IBookRepository
    {
        int Add(BookDto book);
        void Delete(int id);
        List<BookDto> GetAll();
        List<BookDto> GetByAuthorId(int id);
    }
}