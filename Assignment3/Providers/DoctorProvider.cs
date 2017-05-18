using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Assignment3.Models;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace Assignment3.Providers
{
    public class DoctorProvider
    {
        private static string connString;

        public DoctorProvider()
        {
            connString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
        }

        public IList<Doctor> RetrieveDoctor()
        {
            IList<Doctor> doctorsList = new List<Doctor>();

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string statement = "SELECT * FROM doctor";

                MySqlCommand cmd = new MySqlCommand(statement, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Doctor doctor = new Doctor();
                        doctor.id = reader.GetInt32("id");
                        doctor.name = reader.GetString("name");
                        doctor.password = reader.GetString("password");

                        doctorsList.Add(doctor);
                    }
                }
            }

            return doctorsList;
        }


        public void AddDoctor(Doctor doctor)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO doctor(id, name, password) VALUES(@id, @name, @password)";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@id", doctor.id);
                cmd.Parameters.AddWithValue("@name", doctor.name);
                cmd.Parameters.AddWithValue("@password", doctor.password);

                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateDoctor(Doctor doctor)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE doctor SET name = @name, password = @password WHERE id = @id;";

                cmd.Prepare();

                cmd.Parameters.AddWithValue("@id", doctor.id);
                cmd.Parameters.AddWithValue("@name", doctor.name);
                cmd.Parameters.AddWithValue("@password", doctor.password);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteDoctor(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM doctor WHERE id=@id";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }
        }
    }
}