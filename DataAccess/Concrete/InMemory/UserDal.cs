using Core.DataAccess.InMemory;
using Core.Entities;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
   public class UserDal:IUserDal
    {
       public List<User> _users;
        public UserDal()
        {
            _users = new List<User>
            {
                new User{UserId=1,UserName="Mertcan",Email="can.mert.karatas@gmail.com",password="a1b2c3d4e5"},
                new User{UserId=1,UserName="Burak",Email="burak@gmail.com",password="a1b2c3d4e5"},
                new User{UserId=1,UserName="Can",Email="can@gmail.com",password="a1b2c3d4e5"},
                new User{UserId=1,UserName="Veli",Email="veli@gmail.com",password="a1b2c3d4e5"},
                new User{UserId=1,UserName="Ali",Email="ali@gmail.com",password="a1b2c3d4e5"}
            };
        }

        public void Add(User entity)
        {
            _users.Add(entity);
        }

        public void Delete(User entity)
        {
            var itemRemove = _users.Single(d => d.UserId == entity.UserId);
            _users.Remove(itemRemove);
        }

        public List<User> Get(Expression<Func<User, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public User Get(int id)
        {
            return _users.SingleOrDefault(u => u.UserId == id);
        }

        public List<User> Getall()
        {
            return _users.ToList();
        }

        public void Update(User entity)
        {
            var userUpdate = _users.SingleOrDefault(u => u.UserId == entity.UserId);
            userUpdate.UserName = entity.UserName;
            userUpdate.Email = entity.Email;
            userUpdate.password = entity.password;
        }
    }
}
