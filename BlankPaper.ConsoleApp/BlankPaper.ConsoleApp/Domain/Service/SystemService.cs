using BlankPaper.ConsoleApp.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlankPaper.ConsoleApp.Domain.Service
{
    public class SystemService
    {
        protected List<Student> students { get; set; }

        public SystemService()
        {
            this.students = new List<Student>();
        }
        public void SetDataByDefault()
        {
            for (var i = 100; i < 110; i++)
            {
                var student = new Student()
                {
                    Id = i,
                    Name = $"Name-{i}",
                    ClassCode = "计0" + i
                };
                var courses = new List<Course>();
                courses.Add(new Course() { Id = 1001, Name = "C#程序设计", Score = i });
                courses.Add(new Course() { Id = 1002, Name = "HTML+CSS", Score = i });
                courses.Add(new Course() { Id = 1003, Name = "ASP.NET Core", Score = i });
                student.Courses = courses;

                this.students.Add(student);
                
            }
        }

        #region Business Actions
        public void AddStudent(Student model)
        {
            if (students.Exists(x => x.Id == model.Id))
            {
                throw new Exception($"已存在学号为：{model.Id} 的学生！");
            }

            students.Add(model);
            //SaveToFile();
        }

        public Student QueryStudent(int id)
        {
            Student student = null;
            student = this.students.Find(x => x.Id == id);
            return student;
        }
        public void SortByScore()
        {
            this.students.Sort((x, y) =>
            {
                var xScore = x.Courses.Sum(coures => coures.Score);
                var yScore = y.Courses.Sum(coures => coures.Score);
                return yScore.CompareTo(xScore);
            });
        }

        public void LoadFromFile()
        {

        }
        public void SaveToFile()
        {

        }
        #endregion Business Actions

    }
}
