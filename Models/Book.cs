using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookmasterServer.Models;


[Table("Book")]
public class Book
{
    [Column("Key")]
    [Key]
    public string Key { get; set; }

    [Column("Title")]
    [Required]
    [MaxLength(500)]
    public string Title { get; set; }

    [Column("Subtitle")]
    [MaxLength(500)]
    public string? Subtitle { get; set; }

    [Column("FirstPublishDate")]
    [MaxLength(20)]
    public string? FirstPublishDate { get; set; }

    [Column("Description")]
    public string? Description { get; set; }
}

