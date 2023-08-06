using CourseAdoNet.Entities.Concrete;
using System.Collections.Generic;

namespace CourseAdoNet.Business.Abstract
{
    public interface IUserManager
    {
        public List<User> GetAll();

        public User GetById(int id);

        public void Add(User user);

        public void Update(User user);

        public void Delete(int id);

    }
    
}
