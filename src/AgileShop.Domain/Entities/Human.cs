
using System.ComponentModel.DataAnnotations;

namespace AgileShop.Domain.Entities;

public class Human:Auditable
{
    [MaxLength(50)]
    public string First_name { get; set; } = string.Empty;

    [MaxLength(50)]
    public string Last_name { get; set;} = string.Empty;
    
    [MaxLength(9)]
    public string PasswordSeriaNumber { get; set; } = string.Empty;

    public bool IsMale { get; set;}

    public DateOnly BirthDate { get; set; }

    public string Country { get; set; } = string.Empty;

    public string Region { get; set; } = string.Empty;

    public string ImagePath { get; set; } = string.Empty;

    
}
