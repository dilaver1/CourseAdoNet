using CourseAdoNet.Entities.Concrete;
using System.Collections.Generic;

namespace CourseAdoNet.Business.Abstract
{
    public interface IWorldManager
    {
        public List<World> GetByUserId(int id);

        public void Add(World world);

        public void Update(World world);

        public void Delete(int id);
    }
}
