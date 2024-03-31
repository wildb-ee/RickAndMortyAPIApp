using System.Security.Claims;
using AutoMapper;

using RickAndMortyAPIApp.Domain.Entities;
using RickAndMortyAPIApp.Domain.SeedWork;
using RickAndMortyAPIApp.Infrastructure.DTOs;
using System.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Cryptography;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace RickAndMortyAPIApp.Auth.Handlers;

public class LoginHandler
{
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;
    
    public LoginHandler(IMapper mapper, IUnitOfWork unitOfWork)
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }

    private string CreateToken(UserEntity user)
    {
        List<Claim> claims = new List<Claim>
        {
            new Claim(ClaimTypes.Email, user.Email),
            new Claim(ClaimTypes.Name, user.Username)
        };

        var key = new byte[64]; // 64 bytes = 512 bits (the required size for HMAC-SHA512)
        using (var rng = RandomNumberGenerator.Create())
        {
            rng.GetBytes(key);
        }

        var securityKey = new SymmetricSecurityKey(key);
        var creds = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha512);

        var token = new JwtSecurityToken(claims: claims, expires: DateTime.Now.AddDays(1), signingCredentials: creds);

        var jwt = new JwtSecurityTokenHandler().WriteToken(token);

        return jwt;
    }
    public async Task<string> Handle(UserDTO userDto)
    {
        var _userRepository = _unitOfWork.GetRepository<UserEntity>();
        var dbUser = await _userRepository.FirstOrDefault(u => u.Username == userDto.username);

        if (dbUser != null)
        {
            if (BCrypt.Net.BCrypt.Verify(userDto.password, dbUser.Password))
            {
                return CreateToken(dbUser);
            }
        }

        throw new Exception("Error");
    }
    
}