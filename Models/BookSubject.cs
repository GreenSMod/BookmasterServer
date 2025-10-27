using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookmasterServer.Models;


[Table("BookSubject")]
public class BookSubject
{
    [Column("Id")]
    [Key]
    public long Id { get; set; }

    [Column("Subject")]
    [Required]
    [MaxLength(400)]
    public string Subject { get; set; }

    [Column("BookKey")]
    [Required]
    public string BookKey { get; set; }

    [ForeignKey("BookKey")]
    public Book Book { get; set; }
}
