using CRMSwagger.Enums;
using System.ComponentModel.DataAnnotations;

namespace CRMSwagger.Contracts;

#nullable disable

public class LeadDTO
{
    [Required]
    [Range(0, int.MaxValue)]
    public int Id { get; set; } = 0;

    [Required]
    [Range(0, int.MaxValue)]
    public int SaleId { get; set; } = 0;

    [Required]
    [Range(0, int.MaxValue)]
    public int ContactId { get; set; } = 0;

    [Required]
    [EnumDataType(typeof(StatusLead))]
    public StatusLead LeadStatus { get; set; }
}
