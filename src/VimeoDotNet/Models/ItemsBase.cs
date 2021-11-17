using JetBrains.Annotations;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VimeoDotNet.Models
{
    public class ItemsBase1
    {
        [PublicAPI]
        [JsonProperty("uri")]
        public string Uri { get; set; }

        [PublicAPI]
        [JsonProperty("options")]
        public List<string> Options { get; set; }

        [PublicAPI]
        [JsonProperty("total")]
        public int Total { get; set; }
    }
}