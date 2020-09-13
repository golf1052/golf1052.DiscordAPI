using System;
using System.Collections.Generic;
using System.Text;

namespace golf1052.DiscordAPI.Objects.Channel.Requests
{
    public class CreateMessageRequest
    {
        public string Content { get; set; }
        public string Nonce { get; set; }
        public bool TTS { get; set; }
        public byte[] File { get; set; }
        // public Embed Embed {get;set;}
        public string PayloadJson { get; set; }
        // public AllowedMentions AllowedMentions {get;set;}
    }
}
