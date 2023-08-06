using CourseAdoNet.DataAccess.Abstract;
using CourseAdoNet.DataAccess.Constants;
using CourseAdoNet.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CourseAdoNet.DataAccess.Concrete
{
    public class WorldDal : IWorldDal
    {
        public void Add(World world)
        {
            string queryString = $"INSERT INTO Worlds VALUES(@Name,@OwnerId)";
            using SqlConnection connection = new SqlConnection(ConnectionStrings.CourseConnectionString);
            using SqlCommand command = new SqlCommand(queryString, connection);
            command.Parameters.AddWithValue("@Name", world.Name);
            command.Parameters.AddWithValue("@OwnerId", world.OwnerId);
            connection.Open();
            command.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            string DeleteQuery = "DELETE FROM Worlds WHERE Id=@Id";

            using SqlConnection connection = new SqlConnection(ConnectionStrings.CourseConnectionString);
            using SqlCommand command = new SqlCommand(DeleteQuery, connection);
            command.Parameters.AddWithValue("@Id", id);
            connection.Open();
            command.ExecuteNonQuery();
        }

        public List<World> GetByUserId(int ownerId)
        {
            string queryString = "SELECT * FROM Worlds WHERE OwnerId=@OwnerId";

            using SqlConnection connection = new SqlConnection(ConnectionStrings.CourseConnectionString);
            using SqlCommand command = new SqlCommand(queryString, connection);
            command.Parameters.AddWithValue("@OwnerId", ownerId);
            connection.Open();
            using SqlDataReader reader = command.ExecuteReader();

            List<World> worlds = new List<World>();

            while (reader.Read())
            {
                World world = new World(Convert.ToInt32(reader["Id"]), reader["Name"].ToString(), ownerId);
                worlds.Add(world);
            }

            return worlds;
        }

        public void Update(World world)
        {
            string queryString = $"UPDATE Worlds SET Name = @Name WHERE Id = @Id";
            using SqlConnection connection = new SqlConnection(ConnectionStrings.CourseConnectionString);
            using SqlCommand command = new SqlCommand(queryString, connection);
            command.Parameters.AddWithValue("@Id", world.Id);
            command.Parameters.AddWithValue("@Name", world.Name);
            connection.Open();
            command.ExecuteNonQuery();
        }
    }
}
