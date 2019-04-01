using BlankPaper.ConsoleApp.Presentation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlankPaper.ConsoleApp.Domain.Model
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ClassCode { get; set; }
        public List<Course> Courses { get; set; }

        public Student()
        {
            Courses = new List<Course>();
        }
        public void Show(IOutput output)
        {
            output.WriteLine("====>Student Information:");
            output.WriteLine($"Id:{Id},Name:{Name},ClassCode:{ClassCode}");
            output.WriteLine("====>Course Information:");

            foreach (var course in Courses)
            {
                output.WriteLine($"<Id:{course.Id},Name:{course.Name},Score:{course.Score}>");
            }
        }
    }
}
