using CRMSwagger.Enums;

namespace CRMSwagger.Objects;

#nullable disable

public class User
{
    public string Name { get; set; } = string.Empty;

    public string Password { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public int Id { get; set; } = 0;

    public Role Role { get; set; }

    public DateTime DateBlocking { get; set; }
}
