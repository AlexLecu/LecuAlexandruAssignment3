using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Assignment3.Models;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace Assignment3.Providers
{
    public class ConsultationProvider
    {
        private static string connString;

        public ConsultationProvider()
        {
            connString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
        }

        public IList<Consultation> RetrieveConsultation()
        {
            IList<Consultation> consultationList = new List<Consultation>();

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string statement = "SELECT * FROM consultation";

                MySqlCommand cmd = new MySqlCommand(statement, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Consultation consultation = new Consultation();
                        consultation.id = reader.GetInt32("id");
                        consultation.appointment = reader.GetDateTime("appointment");
                        consultation.doctor_id = reader.GetInt32("doctor_id");
                        consultation.patient_identityCardNumber = reader.GetInt32("patient_identityCardNumber");

                        consultationList.Add(consultation);
                    }
                }
            }

            return consultationList;
        }


        public void AddConsultation(Consultation consultation)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO consultation(id, appointment, doctor_id, patient_identityCardNumber) VALUES(@id, @appointment, @doctor_id, @patient_identityCardNumber)";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@id", consultation.id);
                cmd.Parameters.AddWithValue("@appointment", consultation.appointment);
                cmd.Parameters.AddWithValue("@doctor_id", consultation.doctor_id);
                cmd.Parameters.AddWithValue("@patient_identityCardNumber", consultation.patient_identityCardNumber);

                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateConsultation(Consultation consultation)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE consultation SET appointment = @appointment, doctor_id = @doctor_id, patient_identityCardNumber = @patient_identityCardNumber WHERE id = @id;";

                cmd.Prepare();

                cmd.Parameters.AddWithValue("@id", consultation.id);
                cmd.Parameters.AddWithValue("@appointment", consultation.appointment);
                cmd.Parameters.AddWithValue("@doctor_id", consultation.doctor_id);
                cmd.Parameters.AddWithValue("@patient_identityCardNumber", consultation.patient_identityCardNumber);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteConsultation(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM consultation WHERE id=@id";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }
        }

        public IList<Consultation> RetrieveConsultationByPatient(int patient_identityCardNumber)
        {
            IList<Consultation> consultationList = new List<Consultation>();

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string statement = "SELECT * FROM consultation WHERE patient_identityCardNumber=\"" + patient_identityCardNumber + "\";";

                MySqlCommand cmd = new MySqlCommand(statement, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Consultation consultation = new Consultation();
                        consultation.id = reader.GetInt32("id");
                        consultation.appointment = reader.GetDateTime("appointment");
                        consultation.doctor_id = reader.GetInt32("doctor_id");
                        consultation.patient_identityCardNumber = reader.GetInt32("patient_identityCardNumber");

                        consultationList.Add(consultation);
                    }
                }
            }

            return consultationList;

        }
    }
}