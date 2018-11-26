using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectedPart
{
    public class Starships
    {

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("model")]
        public string model { get; set; }

        [JsonProperty("manufacturer")]
        public string manufacturer { get; set; }

        [JsonProperty("cost_in_credits")]
        public string cost_in_credits { get; set; }

        [JsonProperty("length")]
        public string length { get; set; }

        [JsonProperty("max_atmosphering_speed")]
        public string max_atmosphering_speed { get; set; }

        [JsonProperty("crew")]
        public string crew { get; set; }

        [JsonProperty("passengers")]
        public string passengers { get; set; }

        [JsonProperty("cargo_capacity")]
        public string cargo_capacity { get; set; }

        [JsonProperty("consumables")]
        public string consumables { get; set; }

        [JsonProperty("hyperdrive_rating")]
        public string hyperdrive_rating { get; set; }

        [JsonProperty("MGLT")]
        public string MGLT { get; set; }

        [JsonProperty("starship_class")]
        public string starship_class { get; set; }

        [JsonProperty("pilots")]
        public IList<object> pilots { get; set; }

        [JsonProperty("films")]
        public IList<string> films { get; set; }

        [JsonProperty("created")]
        public DateTime created { get; set; }

        [JsonProperty("edited")]
        public DateTime edited { get; set; }

        [JsonProperty("url")]
        public string url { get; set; }
    }
}
