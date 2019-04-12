using System;
using System.Collections.Generic;
using System.Text;

namespace BlankPaper.ConsoleApp.Infrastructure
{
    public partial class ScoreEntity
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? CourseId { get; set; }
        public string Description { get; set; }

        public virtual CourseEntity Course { get; set; }
        public virtual UserEntity User { get; set; }
    }
}
