using PeopleAndBooks.BLL.Model;

namespace PeopleAndBooks.BLL.Service.Interface
{
    public interface IHumanService
    {
        int Add(Human human);
        void Delete(int id);
        void FindHuman();
        List<Human> GetAll();
        List<Human> GetAllAuthor();
    }
}