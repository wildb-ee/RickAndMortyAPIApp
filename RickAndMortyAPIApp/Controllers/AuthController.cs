using ClassLibrary1.IRepositories;
using Microsoft.AspNetCore.Mvc;
using RickAndMortyAPIApp.Domain.Entities;
using RickAndMortyAPIApp.Domain.SeedWork;
using RickAndMortyAPIApp.Infrastructure.DTOs;
using RickAndMortyAPIApp.Infrastructure.Services;

namespace RickAndMortyAPIApp.Controllers;


[ApiController]
[Route("[controller]")]
public class AuthController : ControllerBase
{
    private AuthService _authService;
    public AuthController(AuthService authService)
    {
        _authService = authService;
    }

    [HttpPost("register")]
    public async Task<ActionResult<UserDTO>> Register(UserDTO request)
    {
        return await _authService.Register(request);
    } 
    
    [HttpPost("login")]
    public async Task<ActionResult<string>> Login(UserDTO request)
    {
        return await _authService.Login(request);
    } 

}