using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Assignment3.Models;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace Assignment3.Providers
{
    public class SecretaryProvider
    {
        private static string connString;

        public SecretaryProvider()
        {
            connString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
        }

        public IList<Secretary> RetrieveSecretary()
        {
            IList<Secretary> secretaryList = new List<Secretary>();

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string statement = "SELECT * FROM secretary";

                MySqlCommand cmd = new MySqlCommand(statement, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Secretary secretary = new Secretary();
                        secretary.id = reader.GetInt32("id");
                        secretary.name = reader.GetString("name");
                        secretary.password = reader.GetString("password");

                        secretaryList.Add(secretary);
                    }
                }
            }

            return secretaryList;
        }

        public void AddSecretary(Secretary secretary)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO secretary(id, name, password) VALUES(@id, @name, @password)";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@id", secretary.id);
                cmd.Parameters.AddWithValue("@name", secretary.name);
                cmd.Parameters.AddWithValue("@password", secretary.password);

                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateSecretary(Secretary secretary)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE secretary SET name = @name, password = @password WHERE id = @id;";

                cmd.Prepare();

                cmd.Parameters.AddWithValue("@id", secretary.id);
                cmd.Parameters.AddWithValue("@name", secretary.name);
                cmd.Parameters.AddWithValue("@password", secretary.password);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteSecretary(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM secretary WHERE id=@id";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }
        }
    }
}