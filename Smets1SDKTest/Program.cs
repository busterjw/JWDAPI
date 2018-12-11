using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Smets1SDKTest
{
    public class Program
    {
        public HttpClient client = new HttpClient();

        static void Main(string[] args)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("X-API-Key", "d2dd86f8c7224a458c4f4c47e677aaaf");
                var response = client.GetAsync("https://www.bungie.net/Platform/Destiny2/4/Profile/4611686018485516375/").Result;
                var content = response.Content.ReadAsStringAsync().Result;
                dynamic item = Newtonsoft.Json.JsonConvert.DeserializeObject(content);

                Console.WriteLine(item.Response.data);
            }
        }
    }
}
