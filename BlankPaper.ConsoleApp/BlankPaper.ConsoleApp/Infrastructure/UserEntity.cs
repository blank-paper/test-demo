using System;
using System.Collections.Generic;
using System.Text;

namespace BlankPaper.ConsoleApp.Infrastructure
{
    public partial class UserEntity
    {
        public UserEntity()
        {
            Score = new HashSet<ScoreEntity>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public int? Type { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual ICollection<ScoreEntity> Score { get; set; }
    }
}
