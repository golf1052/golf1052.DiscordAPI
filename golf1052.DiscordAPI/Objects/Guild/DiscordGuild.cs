using System;
using System.Collections.Generic;
using System.Text;
using golf1052.DiscordAPI.Objects.Channel;

namespace golf1052.DiscordAPI.Objects.Guild
{
    public class DiscordGuild
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public List<DiscordChannel> Channels { get; set; }
    }
}
