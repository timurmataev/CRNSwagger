using CRMSwagger.Enums;

namespace CRMSwagger.Objects;

public class Lead
{
    public int Id { get; set; } = 0;

    public int SaleId { get; set; } = 0;

    public int ContactId { get; set; } = 0;

    public StatusLead LeadStatus { get; set; }
}
