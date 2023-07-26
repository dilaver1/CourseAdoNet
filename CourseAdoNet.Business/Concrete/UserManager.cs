using CourseAdoNet.Business.Abstract;
using CourseAdoNet.Business.Exceptions;
using CourseAdoNet.DataAccess.Abstract;
using CourseAdoNet.Entities.Concrete;
using System.Collections.Generic;

namespace CourseAdoNet.Business.Concrete
{
    public class UserManager : IUserManager
    {
        private readonly IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void Add(User user)
        {
            if (user.UserName.Length <= 3)
            {
                throw new ValidationException("Username minimum 3 herfli olmalidir");
            }

            _userDal.Add(user);
        }

        public void Delete(int id)
        {
            _userDal.Delete(id);
        }

        public List<User> GetAll()
        {
            return _userDal.GetAll();
        }

        public User GetById(int id)
        {
            return _userDal.Get(id);
        }

        public void Update(User user)
        {
            if(user.UserName.Length<=3)
            {
                throw new ValidationException("Username minimum 3 herfli olmalidir");
            }

            _userDal.Update(user);
        }
    }
}
