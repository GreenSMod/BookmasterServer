using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookmasterServer.Models;


[Table("Author")]
public class Author
{
    [Column("Key")]
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string Key { get; set; }

    [Column("Name")]
    [Required]
    [MaxLength(100)]
    public string Name { get; set; }

    [Column("Bio")]
    public string? Bio { get; set; }

    [Column("BirthDate")]
    [MaxLength(20)]
    public string? BirthDate { get; set; }

    [Column("DeathDate")]
    [MaxLength(20)]
    public string? DeathDate { get; set; }

    [Column("Wikipedia")]
    [MaxLength(255)]
    public string? Wikipedia { get; set; }
}
