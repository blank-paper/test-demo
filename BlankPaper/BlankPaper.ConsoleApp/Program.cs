using BlankPaper.ConsoleApp.Domain.Model;
using BlankPaper.ConsoleApp.Domain.Service;
using BlankPaper.ConsoleApp.Presentation;
using System;
using System.Collections.Generic;

namespace BlankPaper.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var app = new SystemService();

            SetDataByDefault(app);


            app.LoadFromFile();

            //添加学生
            var stu = new Student()
            {
                Id = 2000,
                Name = "Alan",
                ClassCode = "111",
                Courses = {
                    new Course(){ Id =1001, Name="AAA", Score=98.6m },
                    new Course(){ Id =1002, Name="BBB", Score=98.6m },
                    new Course(){ Id =1003, Name="CCC", Score=98.6m }
                }
            };
            app.AddStudent(stu);


            app.ShowStudent(new ConsoleOutput());


            //按照成绩 - 排序
            app.SortByScore();
            app.ShowStudent(new ConsoleOutput());
            //SetDataByDefault(app);
        }


        static void SetDataByDefault(SystemService service)
        {
            service.SetDataByDefault();
            service.SaveToFile();
            service.LoadFromFile();
        }
    }
}
