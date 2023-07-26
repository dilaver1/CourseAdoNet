using CourseAdoNet.DataAccess.Concrete;
using CourseAdoNet.Entities.Concrete;


UserDal userDal = new UserDal();

var user = userDal.Get(4);

Console.WriteLine(user.UserName);