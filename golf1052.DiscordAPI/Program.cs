using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace golf1052.DiscordAPI
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            DiscordCore discord = new DiscordCore(Secrets.BotbotToken);
            var response = await discord.GetGatewayBot();
        }
    }
}
