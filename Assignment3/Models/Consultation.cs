using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment3.Models
{
    public class Consultation
    {
        public int id { get; set; }
        public DateTime appointment { get; set; }
        public int doctor_id { get; set; }
        public int patient_identityCardNumber { get; set; }
    }
}