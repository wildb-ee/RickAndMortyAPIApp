using System.Text.RegularExpressions;

namespace RickAndMortyAPIApp.Parser;

public static class Helper
{
    public static int GetSearchAfter(string searchAfterText)
    {
        return int.Parse(Regex.Matches(searchAfterText, @"\d{1,}").Last().Value);
    }
}