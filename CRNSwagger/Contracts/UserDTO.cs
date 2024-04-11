using System.ComponentModel.DataAnnotations;

namespace CRMSwagger.Contracts;

#nullable disable

public class UserDTO
{
    [Required]
    public int Id { get; set; }

    [StringLength(30)]
    [Required(AllowEmptyStrings = false)]
    public string Name { get; set; } = string.Empty;

    [StringLength(20)]
    [Required(AllowEmptyStrings = false)]
    public string Password { get; set; } = string.Empty;

    [EmailAddress]
    [StringLength(20)]
    [Required(AllowEmptyStrings = false)]
    public string Email { get; set; } = string.Empty;
}
