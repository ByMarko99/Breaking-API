// Endpoints from API
namespace SussyApi.Components
{
    public class Endpoints
    {
        public static string GetCharacter(string name)
        {
            return $"https://www.breakingbadapi.com/api/characters?name={name}";
        }
        public static string GetRandomQuote()
        {
            return $"https://www.breakingbadapi.com/api/quote/random";
        }


    }

}
