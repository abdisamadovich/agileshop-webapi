
using AgileShop.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace AgileShop.Domain.Entities.Users;

public class User
{
    [MaxLength(13)]
    public string Phone_number { get; set; } = string.Empty;

    public bool PhoneNumberConfirmed { get; set; }

    public string PasswordHash { get; set; } = string.Empty;

    public string Salt { get; set; } = string.Empty;

    public DateTime LastActivity { get; set; }
    public IdentityRole Role { get; set; }
}
