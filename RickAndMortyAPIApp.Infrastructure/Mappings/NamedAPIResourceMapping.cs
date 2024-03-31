using AutoMapper;
using RickAndMortyAPIApp.Domain.SeedWork;
using RickAndMortyAPIApp.Infrastructure.DTOs;
using RickAndMortyAPIApp.Parser.DTOs;

namespace RickAndMortyAPIApp.Infrastructure.Mappings;

public class NamedAPIResourceMapping : Profile
{
    public NamedAPIResourceMapping()
    {
        CreateMap<NamedAPIResourceDTO, NamedAPIResource>()
            .ForMember(dest => dest.Name, 
                opt => opt.MapFrom(src => src.name))
            .ForMember(dest => dest.Url, 
                opt => opt.MapFrom(src => src.url));
    }
}