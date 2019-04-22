using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Demo.WebUI.Models;

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
            //访问数据库获取一个学生列表

            var students = new List<Student>() {
                new Student(){ Id = 10001,Name="Alan",Age=34,Remark="Teacher" },
                new Student(){ Id = 10002,Name="Tom",Age=18,Remark="Student" },
                new Student(){ Id = 10003,Name="Jerry",Age=19,Remark="Student" }
            };
            //ViewData["Students"] = students;

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
