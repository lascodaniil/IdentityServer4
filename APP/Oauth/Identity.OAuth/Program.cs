using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Identity.OAuth
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args);
        }

        public static void CreateWebHostBuilder(string[] args)
        {
            {
                var host = new WebHostBuilder()
                    .UseKestrel()
                    .UseUrls("http://localhost:59418")
                    .UseContentRoot(Directory.GetCurrentDirectory())
                    .UseIISIntegration()
                    .UseStartup<Startup>()
                    .Build();

                host.Run();
            }
        }
    }
}
