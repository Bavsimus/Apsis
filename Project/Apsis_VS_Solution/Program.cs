using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Apsis_190421
{
    public class Program
    {
        //baðlantý cümlesi
        //local public static string cumle = @"data source=DESKTOP-TS9ELJE; database=Apsis; integrated security=SSPI;";
        public static string cumle = @"data source=176.53.65.202\MSSQLSERVER2019; database=apsissit_DB; integrated security=False; User ID=apsissit_talib; Password=Sqse71^5";
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
