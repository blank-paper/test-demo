using BlankPaper.ConsoleApp.Presentation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlankPaper.ConsoleApp.Domain.Model
{
    public class Student
    {
        #region Filed
        public int Id { get; set; }
        public string Name { get; set; }
        public string ClassCode { get; set; }
        public List<Course> Courses { get; set; }
        
        #endregion

        #region Action
        public void ShowInformation(IOutput output)
        {
            output.WriteLine("学生基本信息：");
            output.WriteLine($"==> Id：{this.Id}");
            output.WriteLine($"==> Name：{this.Name}");
            output.WriteLine($"==> ClassCode：{this.ClassCode}");

            output.WriteLine("成绩信息列表：");
            Courses.ForEach(x => x.ShowInformation(output));
            //foreach (var course in Courses)
            //{
            //    course.ShowInformation();
            //}
        }
        #endregion
    }
}

