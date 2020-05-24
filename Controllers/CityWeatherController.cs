using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using nicoletiweathermusic.Models;
using nicoletiweathermusic.Repository;

namespace nicoletiweathermusic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityWeatherController
    {
        [HttpGet("{city}")]
        public async Task<CityWeather> GetCity(string city)
        {
            CityWeatherRepository cidade = new CityWeatherRepository();

            var cid = await cidade.GetCityWeatherAsync(city);

            return cid;
        }
    }
}