using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace BuildOptionSample.Controllers
{
    public class HomeController : Controller
    {

        #region 依赖注入 -- Option的使用

        public readonly ClassInfo classInfo;

        //热更新 ==>IOptionsSnapshot 
        public HomeController(IOptionsSnapshot<ClassInfo> optionsClass)
        {
            classInfo = optionsClass.Value;
        }

        //慢更新
        //public HomeController(IOptions<ClassInfo> optionsClass)
        //{
        //    classInfo = optionsClass.Value;
        //}

        #endregion

        /// <summary>
        /// 通过依赖注入 实现
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View(classInfo);
        }

        /// <summary>
        /// 通过页面直接 调用 option 实现
        /// </summary>
        /// <returns></returns>
        public IActionResult Index2()
        {
            return View();
        }


    }
}