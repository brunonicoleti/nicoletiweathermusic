using Newtonsoft.Json;

namespace nicoletiweathermusic.Models
{
    public class Clouds
    {
        [JsonProperty("all")]
        public int all { get; set; }
    }
}