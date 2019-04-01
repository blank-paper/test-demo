using System;
using System.Collections.Generic;
using System.Text;

namespace BlankPaper.ConsoleApp.Domain.Model
{
    /// <summary>
    /// 课程类
    /// </summary>
    public class Course
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Score { get; set; }

        #region Action
        public void ShowInformation()
        {
            //Console.WriteLine("");
        }
        #endregion
    }
}
