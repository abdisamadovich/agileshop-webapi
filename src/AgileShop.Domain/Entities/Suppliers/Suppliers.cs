
using System.ComponentModel.DataAnnotations;

namespace AgileShop.Domain.Entities.Suppliers;

public class Suppliers:Auditable
{
    [MaxLength(50)]
    public string CompanyName { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    [MaxLength(13)]
    public string FaxPhoneNumber { get; set; } = string.Empty;

    [MaxLength(13)]
    public string ContactPhoneNumber { get; set; } = string.Empty;
}
