using Microsoft.AspNetCore.Mvc;
using RickAndMortyAPIApp.Auth.Handlers;

using RickAndMortyAPIApp.Infrastructure.DTOs;

namespace RickAndMortyAPIApp.Infrastructure.Services;

public class AuthService
{
    private RegistrationHandler _registrationHandler;
    private LoginHandler _loginHandler;

    public AuthService(LoginHandler loginHandler, RegistrationHandler registrationHandler)
    {
        _loginHandler = loginHandler;
        _registrationHandler = registrationHandler;
    }

    public async Task<UserDTO> Register(UserDTO userDto)
    {
        return await _registrationHandler.Handle(userDto);
    }
    
    public async Task<string> Login(UserDTO userDto)
    {
        return await _loginHandler.Handle(userDto);
    }
}