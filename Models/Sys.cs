using Newtonsoft.Json;

namespace nicoletiweathermusic.Models
{
    public class Sys
    {
        [JsonProperty("type")]
        public int type { get; set; }
        [JsonProperty("id")]
        public int id { get; set; }
        [JsonProperty("message")]
        public float message { get; set; }
        [JsonProperty("country")]
        public string country { get; set; }
        [JsonProperty("sunrise")]
        public long sunrise { get; set; }
        [JsonProperty("sunset")]
        public long sunset { get; set; }        
    }
}