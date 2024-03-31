namespace RickAndMortyAPIApp.Parser;

public class APIResult<TDomain> where TDomain: class
{

    public Info Info { get; set; }
    public List<TDomain> Results { get; set; }
}