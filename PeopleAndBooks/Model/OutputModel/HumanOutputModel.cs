namespace PeopleAndBooks.API.Model.OutputModel
{
    public class HumanOutputModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public DateTime Birthday { get; set; }
        public List<BookOutputModel> Books { get; set; }
    }
}
