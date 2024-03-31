using AutoMapper;
using RickAndMortyAPIApp.Domain.Entities;
using RickAndMortyAPIApp.Infrastructure.DTOs;

namespace RickAndMortyAPIApp.Infrastructure.Mappings;

public class UserMapping : Profile
{
    public UserMapping()
    {
        CreateMap<UserDTO, UserEntity>()
            .ForMember(dest => dest.Username,
                opt => opt.MapFrom(src => src.username))
            .ForMember(dest => dest.Email,
                opt => opt.MapFrom(src => src.email))
            .ForMember(dest => dest.Password,
                opt => opt.MapFrom(src =>  BCrypt.Net.BCrypt.HashPassword(src.password)));
        
        CreateMap<UserEntity, UserDTO >()
            .ForMember(dest => dest.username,
                opt => opt.MapFrom(src => src.Username))
            .ForMember(dest => dest.email,
                opt => opt.MapFrom(src => src.Email))
            .ForMember(dest => dest.password,
                opt => opt.MapFrom(src => src.Password));
    }
}