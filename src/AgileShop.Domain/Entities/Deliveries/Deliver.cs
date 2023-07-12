
using System.ComponentModel.DataAnnotations;

namespace AgileShop.Domain.Entities.Deliveries;

public class Deliver : Human
{
    [MaxLength(13)]
    public string PhoneNumber { get; set; } = string.Empty;

    public string PhoneNumberConfirmed { get; set; } = string.Empty;

    public string PasswordHash { get; set; } = string.Empty;

    public string Salt { get; set; } = string.Empty;
}
