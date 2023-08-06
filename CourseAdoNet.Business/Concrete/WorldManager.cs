using CourseAdoNet.Business.Abstract;
using CourseAdoNet.Business.Exceptions;
using CourseAdoNet.DataAccess.Abstract;
using CourseAdoNet.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;


namespace CourseAdoNet.Business.Concrete
{
    public class WorldManager : IWorldManager
    {
        private readonly IWorldDal _worldDal;
        public WorldManager(IWorldDal worldDal)
        {
            _worldDal = worldDal;
        }


        public void Add(World world)
        {
            if (world.Name.Length > 15)
            {
                throw new ValidationException("WorldName maximum 15 herfli olmalidir");
            }

            _worldDal.Add(world);
        }

        public void Delete(int id)
        {
            _worldDal.Delete(id);
        }


        public World GetByUserId(int id)
        {
            return _worldDal.GetByUserId(id);
        }

        public void Update(World world)
        {
            if (world.Name.Length > 15)
            {
                throw new ValidationException("WorldName maximum 15 herfli olmalidir");
            }

            _worldDal.Update(world);
        }
    }
}
