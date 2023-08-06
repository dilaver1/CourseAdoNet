using CourseAdoNet.Entities.Concrete;
using System.Collections.Generic;

namespace CourseAdoNet.DataAccess.Abstract
{
    public interface IWorldDal
    {
        List<World> GetByUserId(int id);
        void Add(World world);
        void Update(World world);
        void Delete(int id);
    }
}
