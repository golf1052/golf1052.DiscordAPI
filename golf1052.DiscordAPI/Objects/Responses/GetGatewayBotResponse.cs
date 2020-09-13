using System;
using System.Collections.Generic;
using System.Text;

namespace golf1052.DiscordAPI.Objects.Responses
{
    public class GetGatewayBotResponse
    {
        public string Url { get; set; }
        public int Shards { get; set; }
        public SessionStartLimit SessionStartLimit { get; set; }
    }
}
