using BlankPaper.ConsoleApp.Domain.Model;
using BlankPaper.ConsoleApp.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.Linq;

namespace BlankPaper.Test
{
    public class DatabaseAccessTest
    {

        //[Theory]
        [Fact]
        public void AddUser_Test()
        {
            var user = new UserEntity() {
                Id = 1,
                Name = "Alan",
                Password = "123456789",
                Type = (int)UserType.Student,
                CreateDate = DateTime.Now,
                UpdateDate = DateTime.Now
            };

            var course = new CourseEntity()
            {
                Id = 1,
                Name = "C#程序设计语言",
                Description = "这是一门很炫酷的语言",
                IsOptional = 1
            };

            using (var context = new MyCourseContext())
            {
                var users = context.User.ToList();
                //context.User.Add(user);
                //context.Course.Add(course);

                context.SaveChanges();
            }
        }
    }
}
