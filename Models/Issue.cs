using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookmasterServer.Models;


[Table("Issue")]
public class Issue
{
    [Column("IssueId")]
    [Key]
    public long IssueId { get; set; }

    [Column("CustomerId")]
    [Required]
    public string CustomerId { get; set; }

    [ForeignKey("CustomerId")]
    public Customer Customer { get; set; }

    [Column("BookKey")]
    [Required]
    public string BookKey { get; set; }

    [ForeignKey("BookKey")]
    public Book Book { get; set; }

    [Column("DateOfIssue")]
    [Required]
    public DateTime DateOfIssue { get; set; }

    [Column("ReturnUntil")]
    [Required]
    public DateTime ReturnUntil { get; set; }

    [Column("ReturnDate")]
    [Required]
    public DateTime? ReturnDate { get; set; }

    [Column("RenewCount")]
    [Required]
    public int RenewCount { get; set; } = 0;

    public bool IsOpen
    { 
        get 
        { 
            return ReturnDate == null; 
        } 
    }

    public bool IsOverdue
    {
        get
        {
            var result = DateTime.Compare(DateTime.Now, ReturnUntil);
            if (result < 0)
                return false;
            return true;
        }
    }
}

