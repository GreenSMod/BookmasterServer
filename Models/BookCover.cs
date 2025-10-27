using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookmasterServer.Models;


[Table("BookCover")]
public class BookCover
{
    [Column("Id")]
    [Key]
    public long Id { get; set; }

    [Column("CoverFile")]
    [Required]
    public int CoverFile { get; set; }

    [Column("BookKey")]
    [Required]
    public string BookKey { get; set; }

    [ForeignKey("BookKey")]
    public Book Book { get; set; }
}
