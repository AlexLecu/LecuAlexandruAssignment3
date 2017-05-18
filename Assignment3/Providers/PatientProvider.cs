using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Assignment3.Models;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace Assignment3.Providers
{
    public class PatientProvider
    {
        private static string connString;

        public PatientProvider()
        {
            connString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
        }

        public IList<Patient> RetrievePatient()
        {
            IList<Patient> patientsList = new List<Patient>();

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string statement = "SELECT * FROM patient";

                MySqlCommand cmd = new MySqlCommand(statement, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Patient patient = new Patient();
                        patient.identityCardNumber = reader.GetInt32("identityCardNumber");
                        patient.name = reader.GetString("name");
                        patient.personalNumericalCode = reader.GetString("personalNumericalCode");
                        patient.address = reader.GetString("address");
                        patient.birthDate = reader.GetDateTime("birthDate");

                        patientsList.Add(patient);
                    }
                }
            }

            return patientsList;
        }


        public void AddPatient(Patient patient)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO patient(identityCardNumber, name, personalNumericalCode, address, birthDate) VALUES(@identityCardNumber, @name, @personalNumericalCode, @address, @birthDate)";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@identityCardNumber", patient.identityCardNumber);
                cmd.Parameters.AddWithValue("@name", patient.name);
                cmd.Parameters.AddWithValue("@personalNumericalCode", patient.personalNumericalCode);
                cmd.Parameters.AddWithValue("@address", patient.address);
                cmd.Parameters.AddWithValue("@birthDate", patient.birthDate);

                cmd.ExecuteNonQuery();
            }
        }

        public void UpdatePatient(Patient patient)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE patient SET name = @name, personalNumericalCode = @personalNumericalCode, address = @address, birthDate = @birthDate WHERE identityCardNumber = @identityCardNumber;";

                cmd.Prepare();

                cmd.Parameters.AddWithValue("@identityCardNumber", patient.identityCardNumber);
                cmd.Parameters.AddWithValue("@name", patient.name);
                cmd.Parameters.AddWithValue("@personalNumericalCode", patient.personalNumericalCode);
                cmd.Parameters.AddWithValue("@address", patient.address);
                cmd.Parameters.AddWithValue("@birthDate", patient.birthDate);
                cmd.ExecuteNonQuery();
            }
        }
    }
}