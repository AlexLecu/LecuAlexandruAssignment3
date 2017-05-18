using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Formatting;

namespace SecretaryClient
{
    public partial class SecretaryForm : Form
    {
        public SecretaryForm()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:53260/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("api/secretary").Result;

            if (response.IsSuccessStatusCode)
            {
                var patients = response.Content.ReadAsAsync<IEnumerable<Patient>>().Result;
                dataGridView1.DataSource = patients;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();

            patient.identityCardNumber =Convert.ToInt32(txtIdentityCardNumber.Text);
            patient.name = txtName.Text;
            patient.personalNumericalCode = txtPersonalNumericalCode.Text;
            patient.address = txtAddress.Text;
            patient.birthDate = dtpBirthDate.Value;

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:53260/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.PostAsJsonAsync("api/secretary", patient).Result;

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Operation succeded");
            }
            else
            {
                MessageBox.Show("Operation failed");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();

            patient.identityCardNumber = Convert.ToInt32(txtIdentityCardNumber.Text);
            patient.name = txtName.Text;
            patient.personalNumericalCode = txtPersonalNumericalCode.Text;
            patient.address = txtAddress.Text;
            patient.birthDate = dtpBirthDate.Value;

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:53260/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.PutAsJsonAsync("api/secretary", patient).Result;

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Operation succeded");
            }
            else
            {
                MessageBox.Show("Operation failed");
            }
        }

        private void btnViewConsultation_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:53260/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("api/secretary/GetConsultation").Result;

            if (response.IsSuccessStatusCode)
            {
                var consultations = response.Content.ReadAsAsync<IEnumerable<Consultation>>().Result;
                dataGridView2.DataSource = consultations;
            }
        }

        private void btnCreateConsultation_Click_1(object sender, EventArgs e)
        {
            Consultation consultation = new Consultation();

            consultation.id = Convert.ToInt32(txtConsultationId.Text);
            consultation.appointment = dtpAppointment.Value;
            consultation.doctor_id = Convert.ToInt32(txtDoctorId.Text);
            consultation.patient_identityCardNumber = Convert.ToInt32(txtPatientIdentityCardNumber.Text);

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:53260/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.PostAsJsonAsync("api/secretary/AddConsultation", consultation).Result;

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Operation succeded");
            }
            else
            {
                MessageBox.Show("Operation failed");
            }
        }

        private void btnUpdateConsultation_Click(object sender, EventArgs e)
        {
            Consultation consultation = new Consultation();

            consultation.id = Convert.ToInt32(txtConsultationId.Text);
            consultation.appointment = dtpAppointment.Value;
            consultation.doctor_id = Convert.ToInt32(txtDoctorId.Text);
            consultation.patient_identityCardNumber = Convert.ToInt32(txtPatientIdentityCardNumber.Text);

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:53260/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.PutAsJsonAsync("api/secretary/UpdateConsultation", consultation).Result;

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Operation succeded");
            }
            else
            {
                MessageBox.Show("Operation failed");
            }
        }

        private void btnDeleteConsultation_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:53260/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.DeleteAsync("api/secretary/DeleteConsultation/"+txtConsultationId.Text).Result;
            
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
