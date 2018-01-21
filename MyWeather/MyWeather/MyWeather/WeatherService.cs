using MyWeather.Models;
using System.Net.Http;
using System.Threading.Tasks;
using static MyWeather.Models.Weather;
using static Newtonsoft.Json.JsonConvert;

namespace MyWeather.Models
{
    public class WeatherService
    {
        const string WeatherCoordinatesUri = "http://api.openweathermap.org/data/2.5/weather?lat={0}&lon={1}&units={2}&appid=fc9f6c524fc093759cd28d41fda89a1b";
        const string WeatherCityUri = "http://api.openweathermap.org/data/2.5/weather?q={0}&appid=fc9f6c524fc093759cd28d41fda89a1b";


        public async Task<WeatherRoot> GetWeather(string city)
            {
            using (var client = new HttpClient())
            {
                var url = string.Format(WeatherCityUri,city);
                    var json = await client.GetStringAsync(url);

                    if (string.IsNullOrWhiteSpace(json))
                        return null;

                    return DeserializeObject<WeatherRoot>(json);
                }

            }
    }
}
