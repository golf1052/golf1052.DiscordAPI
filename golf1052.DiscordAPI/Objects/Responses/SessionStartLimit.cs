using System;
using System.Collections.Generic;
using System.Text;

namespace golf1052.DiscordAPI.Objects.Responses
{
    public class SessionStartLimit
    {
        public int Total { get; set; }
        public int Remaining { get; set; }
        public int ResetAfter { get; set; }
    }
}
