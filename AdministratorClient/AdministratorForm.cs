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

namespace AdministratorClient
{
    public partial class AdministratorForm : Form
    {
        public AdministratorForm()
        {
            InitializeComponent();
        }

        private void btnAddSecretary_Click(object sender, EventArgs e)
        {
            Security secure = new Security();
            Secretary secretary = new Secretary();

            secretary.id = Convert.ToInt32(txtSecretaryId.Text);
            secretary.name = txtSecretaryName.Text;
            secretary.password = secure.HashSHA1(txtSecretaryPassword.Text);

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:53260/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.PostAsJsonAsync("api/Administrator/AddSecretary", secretary).Result;

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Operation succeded");
            }
            else
            {
                MessageBox.Show("Operation failed");
            }
        }

        private void btnUpdateSecretary_Click(object sender, EventArgs e)
        {
            Secretary secretary = new Secretary();
            Security secure = new Security();

            secretary.id = Convert.ToInt32(txtSecretaryId.Text);
            secretary.name = txtSecretaryName.Text;
            secretary.password = secure.HashSHA1(txtSecretaryPassword.Text);

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:53260/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.PutAsJsonAsync("api/Administrator/UpdateSecretary", secretary).Result;

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Operation succeded");
            }
            else
            {
                MessageBox.Show("Operation failed");
            }
        }

        private void btnViewSecretary_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:53260/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("api/Administrator/GetSecretary").Result;

            if (response.IsSuccessStatusCode)
            {
                var secretaries = response.Content.ReadAsAsync<IEnumerable<Secretary>>().Result;
                dataGridViewSecretary.DataSource = secretaries;
            }
        }

        private void btnDeleteSecretary_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:53260/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.DeleteAsync("api/Administrator/DeleteSecretary/" + txtSecretaryId.Text).Result;

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Operation succeded");
            }
            else
            {
                MessageBox.Show("Operation failed");
            }
        }

        private void btnAddDoctor_Click(object sender, EventArgs e)
        {
            Doctor doctor = new Doctor();
            Security secure = new Security();

            doctor.id = Convert.ToInt32(txtDoctorId.Text);
            doctor.name = txtDoctorName.Text;
            doctor.password = secure.HashSHA1(txtSecretaryPassword.Text);

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:53260/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.PostAsJsonAsync("api/Administrator/AddDoctor", doctor).Result;

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Operation succeded");
            }
            else
            {
                MessageBox.Show("Operation failed");
            }
        }

        private void btnUpdateDoctor_Click(object sender, EventArgs e)
        {
            Doctor doctor = new Doctor();
            Security secure = new Security();

            doctor.id = Convert.ToInt32(txtDoctorId.Text);
            doctor.name = txtDoctorName.Text;
            doctor.password = secure.HashSHA1(txtDoctorPassword.Text);

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:53260/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.PutAsJsonAsync("api/Administrator/UpdateDoctor", doctor).Result;

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Operation succeded");
            }
            else
            {
                MessageBox.Show("Operation failed");
            }
        }

        private void btnViewDoctor_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:53260/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("api/Administrator/GetDoctor").Result;

            if (response.IsSuccessStatusCode)
            {
                var doctors = response.Content.ReadAsAsync<IEnumerable<Doctor>>().Result;
                dataGridViewDoctor.DataSource = doctors;
            }
        }

        private void btnDeleteDoctor_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:53260/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.DeleteAsync("api/Administrator/DeleteDoctor/" + txtDoctorId.Text).Result;
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

