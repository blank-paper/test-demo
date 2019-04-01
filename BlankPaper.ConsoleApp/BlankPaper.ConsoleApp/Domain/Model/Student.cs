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
        public void ShowInformation()
        {
            //Console.WriteLine("");
        }
        #endregion
    }
}
