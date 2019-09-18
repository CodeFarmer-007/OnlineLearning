using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;

namespace CommandLineSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.新建字典
            var dri = new Dictionary<string, string>
            {
                { "name" , "张三"},
                { "age" , "99" }
            };

            //2.项目属性==>调试==>应用程序==>输入要解析的字符串


            var build = new ConfigurationBuilder()
                //当未赋值时，则读取内存集合中的默认值
                .AddInMemoryCollection(dri)
                //命令行，进行赋值
                .AddCommandLine(args);

            var config = build.Build();

            Console.WriteLine($"Name:{config["name"]},Age:{config["age"]}");

            Console.ReadLine();
        }
    }
}
