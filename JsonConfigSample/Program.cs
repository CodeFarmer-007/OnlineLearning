using System;
using System.Globalization;
using Microsoft.Extensions.Configuration;

namespace JsonConfigSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //读取Json文件

            var build = new ConfigurationBuilder()
                //参数说明：文件地址，文件不存在是否报异常， 文件更新页面是否及时更新  （热更新）
                .AddJsonFile("class.json", false, true);
                //.AddJsonFile("class.json");

            var config = build.Build();

            Console.WriteLine($"ClassName:{config["className"]},ClassNo:{config["classNo"]}");

            Console.WriteLine("UserInfo");



            Console.WriteLine("************CST**************");

            DateTime date = DateTime.Now;
            var dateCST = date.ToString("ddd MMM dd HH:mm:ss CST yyyy", new CultureInfo("en-us"));
            Console.WriteLine(dateCST);

            Console.WriteLine("************CST**************");



            Console.WriteLine($"UserInfoOne:{config["Info:0:name"]},Age:{config["Info:0:age"]}");

            Console.WriteLine($"UserInfoOne:{config["Info:1:name"]},Age:{config["Info:1:age"]}");

            Console.WriteLine($"UserInfoOne:{config["Info:2:name"]},Age:{config["Info:2:age"]}");

            Console.ReadLine();
        }
    }
}
