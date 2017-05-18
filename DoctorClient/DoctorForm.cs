using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoctorClient
{
    public partial class DoctorForm : Form
    {
        public DoctorForm()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:53260/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("api/Doctor/GetConsultation/" + txtPatientIdentityCardNumber.Text).Result;

            if (response.IsSuccessStatusCode)
            {
                var consultations = response.Content.ReadAsAsync<IEnumerable<Consultation>>().Result;
                dataGridView1.DataSource = consultations;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Consultation consultation = new Consultation();

            consultation.id = Convert.ToInt32(txtConsultationId.Text);
            consultation.appointment = dateTimePicker1.Value;
            consultation.doctor_id = Convert.ToInt32(txtConsultationDoctorId.Text);
            consultation.patient_identityCardNumber = Convert.ToInt32(txtConsultationPatientIdentityCard.Text);

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:53260/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.PutAsJsonAsync("api/Doctor/UpdateConsultation", consultation).Result;

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Operation succeded");
            }
            else
            {
                MessageBox.Show("Operation failed");
            }
        }
    }
}
