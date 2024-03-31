using AutoMapper;
using RickAndMortyAPIApp.Domain.Entities;
using RickAndMortyAPIApp.Infrastructure.DTOs;
using RickAndMortyAPIApp.Parser.DTOs;

namespace RickAndMortyAPIApp.Infrastructure.Mappings;

public class LocationMapping : Profile
{
    public LocationMapping()
    {
        CreateMap<LocationDTO, LocationEntity>()
            .ForMember(dest => dest.Name, 
                opt => opt.MapFrom(src => src.name))
            .ForMember(dest => dest.Type, 
                opt => opt.MapFrom(src => src.type))
            .ForMember(dest => dest.Dimension, 
                opt => opt.MapFrom(src => src.dimension))
            .ForMember(dest => dest.Residents, 
                opt => opt.MapFrom(src => src.residents))
            .ForMember(dest => dest.Url, 
                opt => opt.MapFrom(src => src.url))
            .ForMember(dest => dest.Created, 
                opt => opt.MapFrom(src => src.created))
            .ForMember(dest => dest.SystemId, 
                opt => opt.MapFrom(src => src.id));
    }
}