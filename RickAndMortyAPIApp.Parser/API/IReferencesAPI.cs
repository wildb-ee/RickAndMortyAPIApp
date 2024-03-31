using Refit;
using RickAndMortyAPIApp.Infrastructure.DTOs;
using RickAndMortyAPIApp.Parser.DTOs;

namespace RickAndMortyAPIApp.Parser;

public interface IReferencesAPI
{
    [Get("/character?count={limit}&page={after}")]
    public Task<APIResult<CharacterDTO>> GetCharacters([AliasAs("after")] int after = 0, [AliasAs("limit")] int? limit = 2000);
    [Get("/episode?count={limit}&page={after}")]
    public Task<APIResult<EpisodeDTO>> GetEpisodes([AliasAs("after")] int after = 0, [AliasAs("limit")] int? limit = 2000);
    [Get("/location?count={limit}&page={after}")]
    public Task<APIResult<LocationDTO>> GetLocations([AliasAs("after")] int after = 0, [AliasAs("limit")] int? limit = 2000);
}