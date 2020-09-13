using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace golf1052.DiscordAPI.Objects.Gateway
{
    public class GatewayPayload<T>
    {
        public int Op { get; set; }

        [JsonProperty("d")]
        public T Data { get; set; }

        [JsonProperty("s")]
        public int? SequenceNumber { get; set; }

        [JsonProperty("t")]
        public string Type { get; set; }

        public GatewayPayload()
        {
        }

        public GatewayPayload(int opcode, T data)
        {
            Op = opcode;
            Data = data;
        }
    }
}
