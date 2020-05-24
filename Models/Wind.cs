using Newtonsoft.Json;

namespace nicoletiweathermusic.Models
{
    public class Wind
    {
        [JsonProperty("speed")]
        public float speed { get; set; }
        [JsonProperty("deg")]
        public int deg { get; set; }
    }
}