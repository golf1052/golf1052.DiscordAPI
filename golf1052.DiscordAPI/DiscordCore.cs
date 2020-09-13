using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Flurl;
using golf1052.DiscordAPI.Objects.Channel.Requests;
using golf1052.DiscordAPI.Objects.Responses;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace golf1052.DiscordAPI
{
    public class DiscordCore
    {
        private string BotToken { get; set; }

        private HttpClient httpClient;
        private JsonSerializerSettings jsonSerializerSettings;

        public DiscordCore(string botToken)
        {
            BotToken = botToken;

            jsonSerializerSettings = new JsonSerializerSettings()
            {
                ContractResolver = new DefaultContractResolver()
                {
                    NamingStrategy = new SnakeCaseNamingStrategy()
                },
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore
            };

            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bot", BotToken);
        }

        public async Task<GetGatewayBotResponse> GetGatewayBot()
        {
            Url url = new Url(DiscordConstants.BaseUrl).AppendPathSegments("gateway", "bot");
            HttpResponseMessage responseMessage = await httpClient.GetAsync(url);
            string responseString = await responseMessage.Content.ReadAsStringAsync();
            GetGatewayBotResponse responseObject = JsonConvert.DeserializeObject<GetGatewayBotResponse>(responseString, jsonSerializerSettings);
            return responseObject;
        }

        public async Task CreateMessage(string channelId, CreateMessageRequest createMessageRequest)
        {
            Url url = new Url(DiscordConstants.BaseUrl).AppendPathSegments("channels", channelId, "messages");
            string json = JsonConvert.SerializeObject(createMessageRequest, Formatting.None, jsonSerializerSettings);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage responseMessage = await httpClient.PostAsync(url, content);
            string responseString = await responseMessage.Content.ReadAsStringAsync();
        }
    }
}
