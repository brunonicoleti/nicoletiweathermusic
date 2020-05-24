using System.Threading.Tasks;
using nicoletiweathermusic.Models;
using Refit;

namespace nicoletiweathermusic.Service
{
    public interface ICityWeatherService
    {
        [Get("/data/2.5/weather?q={city}&units=metric&APPID=069410b4bbba32cf046253b5abef5333")]
        Task<CityWeather> GetCityWeather(string city);
    }
}