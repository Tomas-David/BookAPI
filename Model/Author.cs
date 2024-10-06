namespace FullApiBooks.Model
{
    public class Author
    {
        public int Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public ICollection<BookAuthor>? Books { get; set; }
    }
}
