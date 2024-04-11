using CRMSwagger.Contracts;
using CRMSwagger.Data;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace CRMSwagger.Controllers;

[ApiController]
[Route("control")]
public class UsersController : ControllerBase
{
    private readonly ApplicationContext _context;

    public UsersController(ApplicationContext context)
    {
        _context = context;
    }

    [HttpGet("reading")]
    public async Task<IActionResult> GetAllUsers()
    {
        var user = await _context.Users.ToListAsync();

        return Ok(user);
    }

    [HttpPost("addition")]
    public async Task<IActionResult> AdditionUser(UserDTO user)
    {
        await LoginWithHttpContext(user.Email);

        _context.Users.Add(user);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    [HttpPost("deletion")]
    public async Task<IActionResult> DeletionUser(UserDTO user)
    {
        _context.Users.Remove(user);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private Task LoginWithHttpContext(string email)
    {
        var claims = new Claim[]
        {
            new Claim(ClaimTypes.Email, email),
            new Claim("guid", Guid.NewGuid().ToString()),
        };

        ClaimsIdentity identity = new(claims, "Token");
        ClaimsPrincipal principal = new(identity);

        return HttpContext.SignInAsync(principal);
    }
}
