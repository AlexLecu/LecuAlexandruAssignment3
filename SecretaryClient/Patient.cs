using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretaryClient
{
    public class Patient
    {
        public int identityCardNumber { get; set; }
        public string name { get; set; }
        public string personalNumericalCode { get; set; }
        public string address { get; set; }
        public DateTime birthDate { get; set; }
    }
}
