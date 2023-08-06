using CourseAdoNet.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseAdoNet.Business.Abstract
{
    public interface IWorldManager
    {
        
        public World GetByUserId(int id);

        public void Add(World world);

        public void Update(World world);

        public void Delete(int id);
    }
}
