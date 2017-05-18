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
    public partial class DoctorLoginForm : Form
    {
        public DoctorLoginForm()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Security secure = new Security();

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:53260/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("api/Administrator/GetDoctor").Result;

            if (response.IsSuccessStatusCode)
            {
                var doctors = response.Content.ReadAsAsync<IList<Doctor>>().Result;

                for (int i = 0; i < doctors.Count; i++)
                {
                    if (doctors.ElementAt(i).name.Equals(txtDoctorName.Text) && secure.VerifyHash(txtDoctorPassword.Text, doctors.ElementAt(i).password))
                    {
                        DoctorForm df = new DoctorForm();
                        df.Show();
                    }
                }
            }
        }
    }
}
