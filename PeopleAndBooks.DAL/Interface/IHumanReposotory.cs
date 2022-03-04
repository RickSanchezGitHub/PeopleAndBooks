using PeopleAndBooks.DAL.Model;

namespace PeopleAndBooks.DAL.Interface
{
    public interface IHumanReposotory
    {
        int Add(HumanDto newHuman);
        void Delete(int id);
        void FindHuman();
        List<HumanDto> GetAll();
        List<HumanDto> GetAllAuthor();
    }
}