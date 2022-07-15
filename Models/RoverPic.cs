
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Globalization;

namespace RoverAPI.Models
{
    public class Photo
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("sol")]
        public long Sol { get; set; }

        [JsonProperty("camera")]
        public Camera Camera { get; set; }

        [JsonProperty("img_src")]
        public Uri ImgSrc { get; set; }

        [JsonProperty("earth_date")]
        public DateTimeOffset EarthDate { get; set; }

        [JsonProperty("rover")]
        public Rover Rover { get; set; }
    }

    public class Camera
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("rover_id")]
        public long Rover_Id { get; set; }

        [JsonProperty("full_name")]
        public string Full_Name { get; set; }
    }

    public class Rover
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("landing_date")]
        public DateTimeOffset LandingDate { get; set; }

        [JsonProperty("launch_date")]
        public DateTimeOffset LaunchDate { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class Content 
    {
        public List<Photo> Photos { get; set; }
    }
 

   
}
