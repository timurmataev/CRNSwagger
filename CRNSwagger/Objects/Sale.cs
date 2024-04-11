namespace CRMSwagger.Objects;

public class Sale
{
    public int Id { get; set; } = 0;

    public int LeadId { get; set; } = 0;

    public int SalemanId { get; set; } = 0;

    public DateTime DateSale { get; set; }
}
