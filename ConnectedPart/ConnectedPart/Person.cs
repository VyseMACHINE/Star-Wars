using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectedPart
{
  public class People
    {

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("height")]
        public string height { get; set; }

        [JsonProperty("mass")]
        public string mass { get; set; }

        [JsonProperty("hair_color")]
        public string hair_color { get; set; }

        [JsonProperty("skin_color")]
        public string skin_color { get; set; }

        [JsonProperty("eye_color")]
        public string eye_color { get; set; }

        [JsonProperty("birth_year")]
        public string birth_year { get; set; }

        [JsonProperty("gender")]
        public string gender { get; set; }

        [JsonProperty("homeworld")]
        public string homeworld { get; set; }

        [JsonProperty("films")]
        public IList<string> films { get; set; }

        [JsonProperty("species")]
        public IList<string> species { get; set; }

        [JsonProperty("vehicles")]
        public IList<string> vehicles { get; set; }

        [JsonProperty("starships")]
        public IList<string> starships { get; set; }

        [JsonProperty("created")]
        public DateTime created { get; set; }

        [JsonProperty("edited")]
        public DateTime edited { get; set; }

        [JsonProperty("url")]
        public string url { get; set; }
    }
}
