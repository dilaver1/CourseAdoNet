﻿namespace CourseAdoNet.Entities.Concrete
{
    public class World
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int OwnerId { get; set; }


        public World(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
