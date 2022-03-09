namespace PeopleAndBooks.API.Model.InputModel
{
    public class LibraryCardInputModel
    {
        public int ReaderId { get; set; }
        public int BookId { get; set; }
        public DateTime DateTimeOffset { get; set; }
    }
}
