using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace BuildOptionSample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>

            //默认读取 appsetting.json 中的配置数据  
            WebHost.CreateDefaultBuilder(args)  //（默认：热更新）  文件跟踪，一个线程会一直对一个文件进行跟踪，文件变更的时候会发出通知。（根据业务需要，进行开关）
                   .ConfigureAppConfiguration(config =>
                   {
                       config.AddJsonFile("appsettings.json", false, false);// 取消  “热更新”
                   })
                   .UseStartup<Startup>();
    }
}
