using BlankPaper.ConsoleApp.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlankPaper.ConsoleApp.Infrastructure
{
    public class UserRepository
    {
        public void Add(UserEntity user)
        {
            user.Type = (int)UserType.Teacher;
            user.CreateDate = DateTime.Now;
            user.UpdateDate = DateTime.Now;
            using (var dbContext = new MyCourseContext())
            {
                dbContext.Add(user);
                dbContext.SaveChanges();
            }
        }
        public void Update(UserEntity user)
        {
            
        }
        public void Delete(int id)
        {

        }
        public void Query(string Name)
        {

        }
    }
}
