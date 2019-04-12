using System;
using System.Collections.Generic;
using System.Text;

namespace BlankPaper.ConsoleApp.Infrastructure
{
    public partial class CourseEntity
    {
        public CourseEntity()
        {
            Score = new HashSet<ScoreEntity>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? IsOptional { get; set; }

        public virtual ICollection<ScoreEntity> Score { get; set; }
    }
}
