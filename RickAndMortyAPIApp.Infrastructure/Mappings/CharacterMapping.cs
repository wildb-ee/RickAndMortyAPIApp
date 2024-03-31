using AutoMapper;
using RickAndMortyAPIApp.Domain.Entities;
using RickAndMortyAPIApp.Infrastructure.DTOs;
using RickAndMortyAPIApp.Parser.DTOs;

namespace RickAndMortyAPIApp.Infrastructure.Mappings;

public class CharacterMapping : Profile
{
    public CharacterMapping()
    {
        CreateMap<CharacterDTO, CharacterEntity>()
            .ForMember(dest => dest.Name, 
                opt => opt.MapFrom(src => src.name))
            .ForMember(dest => dest.Status, 
                opt => opt.MapFrom(src => src.status))
            .ForMember(dest => dest.Species, 
                opt => opt.MapFrom(src => src.species))
            .ForMember(dest => dest.Type, 
                opt => opt.MapFrom(src => src.type))
            .ForMember(dest => dest.Gender, 
                opt => opt.MapFrom(src => src.gender))
            .ForMember(dest => dest.Location, 
                opt => opt.MapFrom(src => src.location))
            .ForMember(dest => dest.Origin, 
                opt => opt.MapFrom(src => src.origin))
            .ForMember(dest => dest.Image, 
                opt => opt.MapFrom(src => src.image))
            .ForMember(dest => dest.Episode, 
                opt => opt.MapFrom(src => src.episode))
            .ForMember(dest => dest.Url, 
                opt => opt.MapFrom(src => src.url))
            .ForMember(dest => dest.Created, 
                opt => opt.MapFrom(src => src.created))
            .ForMember(dest => dest.SystemId, 
                opt => opt.MapFrom(src => src.id));
    }
}