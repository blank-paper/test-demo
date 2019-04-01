using BlankPaper.ConsoleApp.Domain.Model;
using BlankPaper.ConsoleApp.Domain.Service;
using System;

namespace BlankPaper.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new SystemService();
            service.SetDataByDefault();    //准备数据

            var stu = service.QueryStudent(101);
            service.SortByScore();
        }
    }
}
