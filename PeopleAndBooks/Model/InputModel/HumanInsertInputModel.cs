
using Core;
using Core.Enum;

namespace PeopleAndBooks.API.Model.InputModel
{
    public class HumanInsertInputModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public Role Role { get; set; }
        public DateTime Birthday { get; set; }
    }
}
