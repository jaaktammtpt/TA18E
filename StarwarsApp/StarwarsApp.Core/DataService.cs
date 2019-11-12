using Newtonsoft.Json;
using StarwarsApp.Core.Models;
using System.Net.Http;
using System.Threading.Tasks;

namespace StarwarsApp.Core
{
    public class DataService
    {
        public static async Task<People> GetStarWarsPeople(string queryString)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync(queryString);

            People data = null;
            if (response != null)
            {
                data = JsonConvert.DeserializeObject<People>(response);
            }
            return data;
        }

        public static async Task<Films> GetStarWarsFilms()
        {
            var query = "https://swapi.co/api/films/";
            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync(query);

            Films data = null;
            if (response != null)
            {
                data = JsonConvert.DeserializeObject<Films>(response);
            }
            return data;
        }
    }
}
