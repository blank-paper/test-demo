using Demo.Model;
using Demo.Repository;
using System;
using System.Collections.Generic;

namespace Demo.Business
{
    public class StudentService
    {
        public List<Student> GetAllStudents()
        {
            var repo = new StudentRepository();

            var students = repo.GetAll();
            return students;
        }

        public int AddStudent(Student student)
        {
            throw new NotImplementedException();
        }

        public int GetStudentCourse(Student student)
        {
            var repo = new StudentRepository();

            var optionCourses = repo.Query("选修课");
            var requireCourses = repo.Query("必修课");

           
            throw new NotImplementedException();
        }
    }
}
