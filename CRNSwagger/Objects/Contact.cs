using CRMSwagger.Enums;

namespace CRMSwagger.Objects;

#nullable disable

public class Contact
{
    public string Name { get; set; } = string.Empty;

    public string Lastname { get; set; } = string.Empty;

    public string Patronymic { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string Phone { get; set; } = string.Empty;

    public int Id { get; set; } = 0;

    public int MarketerId { get; set; } = 0;

    public StatusCantact StatusCantact { get; set; }

    public DateTime LastChange { get; set; }
}
