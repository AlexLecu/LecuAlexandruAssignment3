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

namespace SecretaryClient
{
    public partial class SecretaryLoginForm : Form
    {
        public SecretaryLoginForm()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Security secure = new Security();

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:53260/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("api/Administrator/GetSecretary").Result;

            if (response.IsSuccessStatusCode)
            {
                var secretaries = response.Content.ReadAsAsync<IList<Secretary>>().Result;

                for (int i = 0; i < secretaries.Count; i++)
                {
                    if (secretaries.ElementAt(i).Name.Equals(txtSecretaryName.Text) && secure.VerifyHash(txtSecretaryPassword.Text, secretaries.ElementAt(i).Password))
                    {
                        SecretaryForm sf = new SecretaryForm();
                        sf.Show();
                    }
                }
            }

        }
    }
}
