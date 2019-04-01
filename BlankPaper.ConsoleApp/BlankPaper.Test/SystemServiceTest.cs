using BlankPaper.ConsoleApp.Domain.Model;
using BlankPaper.ConsoleApp.Domain.Service;
using System;
using Xunit;

namespace BlankPaper.Test
{
    public class SystemServiceTest
    {
        /// <summary>
        /// This is my unit test.
        /// </summary>
        [Fact]
        public void Test_AddStudent()
        {
            var service = new SystemService();
            service.AddStudent(new Student() { Id = 1001, Name = "Alan" });
            var stu = service.QueryStudent(1001);

            Assert.Equal(1001, stu.Id);
            Assert.Equal("Alan", stu.Name);
        }
    }
}
