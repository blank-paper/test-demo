using Demo.Model;
using System;
using System.Collections.Generic;

namespace Demo.Repository
{
    public class StudentRepository
    {
        public List<Student> GetAll()
        {
            var students = new List<Student>() {
                new Student(){ Id = 10001,Name="Alan",Age=34,Remark="Teacher" },
                new Student(){ Id = 10002,Name="Tom",Age=18,Remark="Student" },
                new Student(){ Id = 10003,Name="Jerry",Age=19,Remark="Student" }
            };
            return students;
        }

        public List<Student> Query(string name)
        {
            throw new NotImplementedException();
        }
        public List<Student> Query(int id)
        {
            throw new NotImplementedException();
        }
        public int Add(Student Student)
        {
            //EF Core 做数据库操作
            throw new NotImplementedException();
        }
    }
}
