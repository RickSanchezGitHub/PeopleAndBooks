using PeopleAndBooks.DAL.Entity;

namespace PeopleAndBooks.DAL.Reposotory.Interface
{
    public interface ILibraryCardRepository
    {
        int Add(LibraryCardDto newLibraryCard);
    }
}