namespace PeopleAndBooks.API.Model.InputModel
{
    public class BookInsertInputModel
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public int AuthorId { get; set; }
    }
}
