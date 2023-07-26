using CourseAdoNet.DataAccess.Abstract;
using CourseAdoNet.DataAccess.Constants;
using CourseAdoNet.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CourseAdoNet.DataAccess.Concrete
{
    public class UserDal : IUserDal
    {
        public void Add(User user)
        {
            //SQL Injection
            string queryString = $"INSERT INTO Users VALUES(@UserName,@Email)";

            using SqlConnection connection = new SqlConnection(ConnectionStrings.CourseConnectionString);
            using SqlCommand command = new SqlCommand(queryString, connection);
            command.Parameters.AddWithValue("@UserName", user.UserName);
            command.Parameters.AddWithValue("@Email", user.Email);
            connection.Open();
            command.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            string DeleteQuery = "DELETE FROM Users WHERE Id=@Id";

            using SqlConnection connection = new SqlConnection(ConnectionStrings.CourseConnectionString);
            using SqlCommand command = new SqlCommand(DeleteQuery, connection);
            command.Parameters.AddWithValue("@Id", id);
            connection.Open();
            command.ExecuteNonQuery();
        }

        public User Get(int id)
        {
            string queryString = "SELECT * FROM Users WHERE Id=@Id";

            using SqlConnection connection = new SqlConnection(ConnectionStrings.CourseConnectionString);
            using SqlCommand command = new SqlCommand(queryString, connection);
            command.Parameters.AddWithValue("@Id", id);
            connection.Open();
            using SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            User user = new User(Convert.ToInt32(reader["Id"]), reader["UserName"].ToString(), reader["Email"].ToString());

            return user;
        }

        public List<User> GetAll()
        {
            List<User> list = new List<User>();
            string queryString = "SELECT * FROM Users";

            using SqlConnection connection = new SqlConnection(ConnectionStrings.CourseConnectionString);
            using SqlCommand command = new SqlCommand(queryString, connection);
            connection.Open();
            using SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                User user = new User(Convert.ToInt32(reader["Id"]), reader["UserName"].ToString(), reader["Email"].ToString());
                list.Add(user);
            }
            return list;
        }

        public void Update(User user)
        {
            string queryString = $"UPDATE Users SET UserName = @UserName, Email = @Email WHERE Id = @Id";

            using SqlConnection connection = new SqlConnection(ConnectionStrings.CourseConnectionString);
            using SqlCommand command = new SqlCommand(queryString, connection);
            command.Parameters.AddWithValue("@Id", user.Id);
            command.Parameters.AddWithValue("@UserName", user.UserName);
            command.Parameters.AddWithValue("@Email", user.Email);
            connection.Open();
            command.ExecuteNonQuery();
        }
    }
}
