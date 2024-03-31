namespace RickAndMortyAPIApp.Infrastructure.DTOs;

public class PageDTO<T>
{
    public PageInfoDTO info { get; set; }
    public IEnumerable<T> results { get; set; }
}