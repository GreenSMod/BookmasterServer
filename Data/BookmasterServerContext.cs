using BookmasterServer.Models;
using Microsoft.EntityFrameworkCore;

namespace BookmasterServer.Data
{
    public class BookmasterServerContext : DbContext
    {
        public BookmasterServerContext(DbContextOptions<BookmasterServerContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<BookAuthor>().HasKey(bookAuthor => new { bookAuthor.BookKey, bookAuthor.AuthorKey });

            //modelBuilder.Entity<Book>().HasData(
            //    new Book
            //    {
            //        Title = "Гамлет",
            //        Description = "Классика мировой литературы"
            //    }
            //    );
        }

        public DbSet<Author> Authors { get; set; }

        public DbSet<Book> Books { get; set; }

        public DbSet<BookAuthor> BookAuthors { get; set; }

        public DbSet<BookCover> BookCovers { get; set; }

        public DbSet<BookSubject> BookSubjects { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Issue> Issues { get; set; }
    }
}
