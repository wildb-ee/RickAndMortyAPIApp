using RickAndMortyAPIApp.Parser.Handlers;

namespace RickAndMortyAPIApp.Infrastructure.Services;

public class ReferencesManagerService
{
    private ExtractCharacterHandler _characterHandler;
    private ExtractEpisodeHandler _episodeHandler;
    private ExtractLocationHandler _locationHandler;
    public ReferencesManagerService(ExtractCharacterHandler characterHandler, ExtractEpisodeHandler episodeHandler,ExtractLocationHandler locationHandler )
    {
        _characterHandler = characterHandler;
        _episodeHandler = episodeHandler;
        _locationHandler = locationHandler;
    }


    public async Task ExtractAllReferences()
    {
        _characterHandler.SetNext(_episodeHandler);
        _episodeHandler.SetNext(_locationHandler);
        await _characterHandler.Handle(new { });

    }

}