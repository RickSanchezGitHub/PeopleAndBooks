using PeopleAndBooks.DAL.Model;

namespace PeopleAndBooks.DAL.Interface
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