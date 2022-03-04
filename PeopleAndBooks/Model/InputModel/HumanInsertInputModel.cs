
namespace PeopleAndBooks.API.Model.InputModel
{
    public class HumanInsertInputModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public DateTime Birthday { get; set; }
    }
}
