using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace golf1052.DiscordAPI.Objects.Gateway
{
    public class IdentifyConnectionProperties
    {
        [JsonProperty("$os")]
        public string OS { get; set; }
        
        [JsonProperty("$browser")]
        public string Browser { get; set; }

        [JsonProperty("$device")]
        public string Device { get; set; }
    }
}
