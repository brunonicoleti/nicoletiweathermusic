using Newtonsoft.Json;

namespace nicoletiweathermusic.Models
{
    public class Coord
    {
        [JsonProperty("lon")]
        public float lon { get; set; }
        [JsonProperty("lat")]
        public float lat { get; set; }
    }
}