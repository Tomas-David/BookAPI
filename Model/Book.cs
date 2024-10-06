namespace FullApiBooks.Model
{
    public class Book
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public ICollection<BookAuthor>? Authors { get; set; }

    }
}
