using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Mission10_Harrison.Data;

public class Bowler
{
    [Key]
    [Required]
    public int BowlerId { get; set; }
    [Required]
    public string BowlerLastName { get; set; }
    [Required]
    public string BowlerFirstName { get; set; }
    public string? BowlerMiddleInit { get; set; }
    [Required]
    public string BowlerAddress { get; set; }
    [Required]
    public string BowlerCity { get; set; }
    [Required]
    public string BowlerState { get; set; }
    [Required]
    public int BowlerZip { get; set; }
    [Required]
    public string BowlerPhoneNumber { get; set; }
    [Required]
    [ForeignKey("TeamId")]
    public int TeamId { get; set; }
    public Team Team { get; set; }

}