using System.ComponentModel.DataAnnotations;

namespace Mission10_Harrison.Data;

public class Team
{
    [Key]
    public int TeamId { get; set; }
    [Required]
    public string TeamName { get; set; }
    public int CaptainId { get; set; }
    
    public ICollection<Bowler> Bowlers { get; set; }
}