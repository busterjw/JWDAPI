using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Smets1SDKTest
{
    public class APIInit
    {
        public HttpClient Clientbuilder(string xApiKey, string apiKey)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add(xApiKey, apiKey);

                return client;
            }
        }
    }
}
