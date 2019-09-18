using System;
using Microsoft.Extensions.Configuration;

namespace JsonConfigSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //读取Json文件

            var build = new ConfigurationBuilder().AddJsonFile("class.json");

            var config = build.Build();

            Console.WriteLine($"ClassName:{config["className"]},ClassNo:{config["classNo"]}");

            Console.WriteLine("UserInfo");

            Console.WriteLine($"UserInfoOne:{config["Info:0:name"]},Age:{config["Info:0:age"]}");

            Console.WriteLine($"UserInfoOne:{config["Info:1:name"]},Age:{config["Info:1:age"]}");

            Console.WriteLine($"UserInfoOne:{config["Info:2:name"]},Age:{config["Info:2:age"]}");

            Console.ReadLine();
        }
    }
}
