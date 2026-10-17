using InfinityTask.Data;
using InfinityTask.DTOs;
using InfinityTask.Models;
using Microsoft.AspNetCore.Mvc;
namespace InfinityTask.Controllers;

[ApiController]
[Route("api/[controller]")]

public class AuthController : ControllerBase
{
    private readonly AppDbContext _context;

    public AuthController(AppDbContext appDbContext)
    { 
        _context = appDbContext;
    }
    
    [HttpPost("register")]
    public IActionResult Register(RegisterDto request)
    {
        if (_context.Users.Any(user => user.Login == request.Login))
        {
            return BadRequest();
        }
        
        string hash = BCrypt.Net.BCrypt.HashPassword(request.Password);
        var user = new User
        {
            Login = request.Login,
            PasswordHash = hash,
            EloRating = 1200,
            Role = "Student"
        };
        _context.Users.Add(user);
        _context.SaveChanges();
        return Created();
    }

    [HttpPost("login")]
    public IActionResult Login(LoginDto request)
    {
        var user = _context.Users.FirstOrDefault(user => user.Login == request.Login);
        if (user == null)
        {
            return Unauthorized();
        }

        bool isPasswordValid = BCrypt.Net.BCrypt.Verify(request.Password, user.PasswordHash);
        if (isPasswordValid == false)
        {
            return Unauthorized();
        }
        
        return Ok();
    }
}