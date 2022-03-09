using PeopleAndBooks.DAL.Entity;

namespace PeopleAndBooks.DAL.Repository.Interface
{
    public interface IHumanReposotory
    {
        int Add(HumanDto newHuman);
        void Delete(int id);
        List<HumanDto> FindHumans(string text);
        List<HumanDto> GetAll();
        List<HumanDto> GetAllAuthor();
    }
}