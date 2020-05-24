using System;
using System.Threading.Tasks;
using nicoletiweathermusic.Models;
using nicoletiweathermusic.Service;
using Refit;

namespace nicoletiweathermusic.Repository
{
    public class CityWeatherRepository
    {
        public async Task<CityWeather> GetCityWeatherAsync(string city)
        {
            try
            {
                var cityWeather = RestService.For<ICityWeatherService>("http://api.openweathermap.org");
                
                var cidade = await cityWeather.GetCityWeather(city);

                return cidade as CityWeather;

            } catch (Exception e)
            {
                System.Console.WriteLine("Erro na consulta da cidade: " + e.Message);
            }
            return new CityWeather();
        }
    }
}