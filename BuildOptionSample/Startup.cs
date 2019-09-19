using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace BuildOptionSample
{
    public class Startup
    {
        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // Option从这里 读映射 实体
            services.Configure<ClassInfo>(_configuration);

            //添加注入 Mvc格式
            services.AddMvc();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //添加  Mvc 默认路由
            app.UseMvcWithDefaultRoute();


            //****************** 一、Builder  ****************************

            //app.Run(async (context) =>
            //{
            //    #region Builder 

            //    //Json文件转换成实体，相互映射起来
            //    ClassInfo myClass = new ClassInfo();
            //    //默认读取 appsetting.json 中的数据，并与实体进行匹配

            //    //Build()配置文件的信息，和对象对应起来
            //    _configuration.Bind(myClass);

            //    await context.Response.WriteAsync($"ClassName:{_configuration["className"]}");
            //    await context.Response.WriteAsync($"ClassNo:{_configuration["classNo"]}");

            //    await context.Response.WriteAsync("Hello World!");

            //    #endregion
            //});

        }
    }
}
