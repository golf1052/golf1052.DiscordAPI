using System;
using System.Collections.Generic;
using System.Text;

namespace golf1052.DiscordAPI.Objects.Gateway
{
    public class Identify
    {
        public string Token { get; set; }
        public IdentifyConnectionProperties Properties { get; set; }
        public bool? Compress { get; set; }
        public int? LargeThreshold { get; set; }
        public int[] Shard { get; set; }
        public UpdateStatus Presence { get; set; }
        public bool? GuildSubscriptions { get; set; }
        public int? Intents { get; set; }
    }
}
