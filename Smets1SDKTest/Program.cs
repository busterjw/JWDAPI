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
            var terminalhandler = new Terminal();
            var init = new APIInit();
            var client = init.Clientbuilder("test", "test1");
            terminalhandler.InitializeTerminal();
        }
    }
}
