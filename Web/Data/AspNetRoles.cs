using System.ComponentModel.DataAnnotations;

namespace Web.Data;

public class AspNetRole
{
    [Key]
    public string Id { get; set; }
    // public string Name { get; set; }
    // public string NormalizedName { get; set; }
    // public string ConcurrencyStamp { get; set; }
    
    public List<ApplicationUser> ApplicationUsers { get; set; }
}
