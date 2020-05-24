using Newtonsoft.Json;

namespace nicoletiweathermusic.Models
{
    public class Main
    {
        [JsonProperty("temp")]
        public float temp { get; set; }
        [JsonProperty("feels_like")]
        public float feelsLike { get; set; }
        [JsonProperty("temp_min")]
        public float tempMin { get; set; }
        [JsonProperty("temp_max")]
        public float tempMax { get; set; }
        [JsonProperty("pressure")]
        public float pressure { get; set; }
        [JsonProperty("humidity")]
        public int humidity { get; set; }        
    }
}