using CRMSwagger.Admin;
using Microsoft.AspNetCore.Mvc;

namespace CRMSwagger.Controllers;

[ApiController]
[Route("entrance")]
public class AdminController : ControllerBase
{
    private string _name = "Undefined";
    private int _password = 0;
    private string _email = "Undefined";

    /// <summary>
    /// Verification based on embedded data in the code
    /// </summary>
    /// <param name="name"></param>
    /// <param name="password"></param>
    /// <param name="email"></param>
    /// <returns> Built-in negative response </returns>
    [HttpPost("admin")]
    public IActionResult CheckForAdmin(string name, int password, string email)
    {
        if (name == DataAdmin.NAME && password == DataAdmin.PASSWORD
            && email == DataAdmin.EMAIL)
        {
            _name = name;
            _password = password;
            _email = email;

            return Ok();
        }

        return Unauthorized();
    }
}
