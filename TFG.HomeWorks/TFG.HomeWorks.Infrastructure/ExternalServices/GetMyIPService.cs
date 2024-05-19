using System.Net.Http.Json;
using TFG.HomeWorks.Application.ExternalServices;

namespace TFG.HomeWorks.Infrastructure.ExternalServices
{
    public class Myipcom_MyIPService : IMyIpService
    {
        private readonly HttpClient client;

        public Myipcom_MyIPService(HttpClient client)
        {
            this.client = client;
        }

        public class MyipcomResponseModel
        {
            public string? Ip { get; set; }
            public string? Country { get; set; }
            public string? Cc { get; set; }
        }

        public async Task<string> GetIPAsync()
        {
            var response = await client.GetFromJsonAsync<MyipcomResponseModel>("");

            return response!.Ip ?? string.Empty;
        }
    }
}
