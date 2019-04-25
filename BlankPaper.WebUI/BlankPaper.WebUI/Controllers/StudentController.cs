using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Demo.Model;
using Demo.Business;

namespace Demo.WebUI.Controllers
{
    public class StudentController : Controller
    {
        /// <summary>
        /// 显示学生主页列表信息
        /// </summary>
        /// <returns></returns>
        public IActionResult Index(string name, int age)
        {
            //数据校验 

            //访问数据库获取一个学生列表
            var service = new StudentService();
            var students = service.GetAllStudents();
            return View("Index", students);
        }
        /// <summary>
        /// 显示学生明细信息
        /// </summary>
        /// <returns></returns>
        public IActionResult Detail(int id)
        {

            return View(id);
        }
    }
}
