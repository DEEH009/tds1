using Microsoft.AspNetCore.Mvc;
using DTO;
namespace back.Controllers;
using Model;
[ApiController]
[Route("[user]")]
public class UserController : ControllerBase
{
    [HttpPost("login")]
    public IActionResult Login()
    {
throw new NotFiniteNumberException();
        
    }
    [HttpPost("registro")]
    public IActionResult Register(
        [FromBody] Usuariodto user
    )
    {
        using Tds12Context context = new Tds12Context();
        Usuario usuario = new Usuario();
        usuario.Nome = user.Name;
        usuario.DataNascimento = user.BirthDate;
        usuario.UserId = user.UserId;
        usuario.Userpass = user.Password;

        context.Add(usuario);
        context.SaveChanges();

        return Ok();



    }
    [HttpPost("Update")]
    public IActionResult Updatename()
    {
        throw new NotFiniteNumberException();
    }

}


