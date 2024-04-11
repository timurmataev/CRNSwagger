using System.ComponentModel.DataAnnotations;

namespace CRMSwagger.Contracts;

#nullable disable

public class SaleDTO
{
    [Required]
    [Range(0, int.MaxValue)]
    public int Id { get; set; } = 0;

    [Required]
    [Range(0, int.MaxValue)]
    public int LeadId { get; set; } = 0;

    [Required]
    [Range(0, int.MaxValue)]
    public int SalemanId { get; set; } = 0;

    [Required]
    public DateTime DateSale { get; set; }
}
