using FullApiBooks.Model;
using Microsoft.EntityFrameworkCore;
namespace FullApiBooks.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Author> Authors { get; set; } = null!;
        public DbSet<Book> Books { get; set; } = null!;
        public DbSet<BookAuthor> BookAuthors { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var autor1 = new Author {Id = 1, FirstName = "John", LastName = "Doe" };
            var autor2 = new Author { Id = 2, FirstName = "Jane", LastName = "Doe" };

            var book1 = new Book { Id = 1, Title = "Book 1" };
            var book2 = new Book { Id = 2, Title = "Book 2" };
            modelBuilder.Entity<Author>().HasData(autor1, autor2);
            modelBuilder.Entity<Book>().HasData(book1, book2);

            
            modelBuilder.Entity<BookAuthor>()
               .HasKey(ba => new { ba.BookId, ba.AuthorId });
            /* modelBuilder.Entity<BookAuthor>()
                 .HasOne(ba => ba.Book)
                 .WithMany(b => b.Authors)
                 .HasForeignKey(ba => ba.BookId);*/







            base.OnModelCreating(modelBuilder);
        }
    }
    
}
