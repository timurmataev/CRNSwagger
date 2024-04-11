using CRMSwagger.Enums;
using System.ComponentModel.DataAnnotations;

namespace CRMSwagger.Contracts;

#nullable disable

public class ContactDTO
{
    [StringLength(20)]
    [Required(AllowEmptyStrings = false)]
    public string Name { get; set; } = string.Empty;

    [StringLength(20)]
    [Required(AllowEmptyStrings = false)]
    public string Lastname { get; set; } = string.Empty;

    [StringLength(20)]
    [Required(AllowEmptyStrings = false)]
    public string Patronymic { get; set; } = string.Empty;

    [EmailAddress]
    [StringLength(20)]
    [Required(AllowEmptyStrings = false)]
    public string Email { get; set; } = string.Empty;

    [Phone]
    [StringLength(20)]
    [Required(AllowEmptyStrings = false)]
    public string Phone { get; set; } = string.Empty;

    [Required]
    [Range(0, int.MaxValue)]
    public int Id { get; set; } = 0;

    [Required]
    [Range(0, int.MaxValue)]
    public int MarketerId { get; set; } = 0;

    [Required]
    [EnumDataType(typeof(StatusCantact))]
    public StatusCantact StatusCantact { get; set; }

    [Required]
    public DateTime LastChange { get; set; }
}
