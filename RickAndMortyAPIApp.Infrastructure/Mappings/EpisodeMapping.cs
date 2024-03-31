using AutoMapper;
using RickAndMortyAPIApp.Domain.Entities;
using RickAndMortyAPIApp.Infrastructure.DTOs;
using RickAndMortyAPIApp.Parser.DTOs;

namespace RickAndMortyAPIApp.Infrastructure.Mappings;

public class EpisodeMapping : Profile
{
    public EpisodeMapping()
    {
        CreateMap<EpisodeDTO, EpisodeEntity>()
            .ForMember(dest => dest.Name, 
                opt => opt.MapFrom(src => src.name))
            .ForMember(dest => dest.AirDate, 
                opt => opt.MapFrom(src => src.air_date))
            .ForMember(dest => dest.Episode, 
                opt => opt.MapFrom(src => src.episode))
            .ForMember(dest => dest.Characters, 
                opt => opt.MapFrom(src => src.characters))
            .ForMember(dest => dest.Url, 
                opt => opt.MapFrom(src => src.url))
            .ForMember(dest => dest.Created, 
                opt => opt.MapFrom(src => src.created))
            .ForMember(dest => dest.SystemId, 
                opt => opt.MapFrom(src => src.id));
    }
}