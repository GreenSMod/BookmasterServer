using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace BookmasterServer.Models;


[Table("BookAuthor")]
public class BookAuthor
{
    [Column("BookKey")]
    public string BookKey { get; set; }

    [ForeignKey("BookKey")]
    public Book Book { get; set; }

    [Column("AuthorKey")]
    public string AuthorKey { get; set; }

    [ForeignKey("AuthorKey")]
    public Author Author { get; set; }
}

