using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace golf1052.DiscordAPI.Objects.Gateway
{
    public class UpdateStatus
    {
        public int? Since { get; set; }
        public Activity Game { get; set; }
        public string Status { get; set; }
        public bool AFK { get; set; }
    }
}
