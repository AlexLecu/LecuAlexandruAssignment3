using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment3.Models
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