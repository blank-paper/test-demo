using BlankPaper.ConsoleApp.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Newtonsoft.Json;
using System.IO;
using BlankPaper.ConsoleApp.Presentation;

namespace BlankPaper.ConsoleApp.Domain.Service
{
    /// <summary>
    /// 系统服务
    /// </summary>
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
                // AddStudent(student); 哪一个好？？
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
            SaveToFile();
        }

        public Student QueryStudent(int id)
        {
            Student student = null;
            student = students.Find(x => x.Id == id);
            return student;
        }
        public Student QueryStudent(string name)
        {
            Student student = null;
            student = students.Find(x => x.Name == name);
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

        // 其他操作... ... 
        #endregion Actions

        #region Persistence Actions

        public void ShowStudent(IOutput output)
        {
            foreach (var student in students)
            {
                student.Show(output);
            }
        }
        public void LoadFromFile()
        {
            var strData = File.ReadAllText("D:/student.txt");             //保存文件
            this.students = JsonConvert.DeserializeObject<List<Student>>(strData);
        }
        public void SaveToFile()
        {           
            var strData = JsonConvert.SerializeObject(this.students);   //序列化

            File.WriteAllText("D:/student.txt",strData);             //保存文件
        }
        #endregion
    }
}
