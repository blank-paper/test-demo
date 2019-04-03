using BlankPaper.ConsoleApp.Domain.Model;
using BlankPaper.ConsoleApp.Domain.Service;
using BlankPaper.ConsoleApp.Presentation;
using System;

namespace BlankPaper.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 实现学生成绩的插入、
             * 通过名字查询
             * 显示总成绩排名列表
             */
            var service = new SystemService();
            service.SetDataByDefault();    //准备数据

            //service.ShowStudentInformations(100, new ConsoleOutput());
            service.ShowStudentInformations(100, new ConsoleOutput());
            

            //var stu = service.QueryStudent(101);
            //service.SortByScore();
        }

        
    }
}
