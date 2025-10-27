using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookmasterServer.Models;


[Table("Customer")]
public class Customer
{
    [Column("CustomerId")]
    [Key]
    public string CustomerId { get; set; }

    [Column("Name")]
    [Required]
    [MaxLength(200)]
    public string Name { get; set; }

    [Column("Address")]
    [Required]
    [MaxLength(300)]
    public string Address { get; set; }

    [Column("Zip")]
    [Required]
    [MaxLength(20)]
    public string Zip { get; set; }

    [Column("City")]
    [Required]
    [MaxLength(100)]
    public string City { get; set; }

    [Column("Phone")]
    [MaxLength(50)]
    public string? Phone { get; set; }

    [Column("Email")]
    [MaxLength(254)]
    public string? Email { get; set; }
}
