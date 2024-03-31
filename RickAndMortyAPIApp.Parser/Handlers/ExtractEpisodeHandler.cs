using AutoMapper;
using Refit;
using RickAndMortyAPIApp.Domain.Entities;
using RickAndMortyAPIApp.Domain.SeedWork;
using RickAndMortyAPIApp.Infrastructure.DTOs;
using RickAndMortyAPIApp.Parser.DTOs;

namespace RickAndMortyAPIApp.Parser.Handlers;

public class ExtractEpisodeHandler: AbstractHandler
{
    private readonly IReferencesAPI _referencesApi;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;
    private List<EpisodeDTO> _DTOlist = new();

    
    public ExtractEpisodeHandler(IReferencesAPI referencesApi, IMapper mapper, IUnitOfWork unitOfWork)
    {
        _referencesApi = referencesApi;
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }
    public override async Task<object> Handle(object request)
    {

        var data = await GetDataRecursive(0);
        if (data)
        {
            try
            {
                var items = _mapper.Map<List<EpisodeDTO>, List<EpisodeEntity>>(_DTOlist);
                var _episodeRepository = _unitOfWork.GetRepository<EpisodeEntity>();
                await _episodeRepository.AddRangeAsync(items.ToArray());
                await _unitOfWork.SaveChangesAsync();
                
            }
            catch (Exception exception)
            {
                return base.Handle(request);
            }
        }
        
        return base.Handle(request);
    }
    protected virtual async Task<bool> GetDataRecursive(int after)
    {
        try
        {
            var result = await _referencesApi.GetEpisodes(after);
            _DTOlist.AddRange(result.Results.ToList());
            if (string.IsNullOrEmpty(result.Info.Next))
            {
                return true;
            }
            return await GetDataRecursive(Helper.GetSearchAfter(result.Info.Next));
        }
        catch (ApiException exception)
        {
            var errors = await exception.GetContentAsAsync<Dictionary<string, string>>();
            if (errors?.Values != null)
            {
                var message = string.Join("; ", errors.Values);
                Console.WriteLine(message);
            }
            else
            {
                Console.WriteLine(exception.ToString());
            }
            return false;
        }
    }
    
}