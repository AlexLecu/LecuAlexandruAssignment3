using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using Assignment3.Providers;
using Assignment3.Models;
using System.Web.Http;

namespace Assignment3.Controllers
{
    [RoutePrefix("api/Doctor")]
    public class DoctorController : ApiController
    {
        ConsultationProvider cp = new ConsultationProvider();

        //GET: api/Doctor/GetConsultation
        [Route("GetConsultation/{patient_identityCardNumber}")]
        public IEnumerable<Consultation> GetConsultation(int patient_identityCardNumber)
        {
            return cp.RetrieveConsultationByPatient(patient_identityCardNumber);
        }


        // PUT: api/Doctor/UpdateConsultation
        [Route("UpdateConsultation")]
        public void Put([FromBody]Consultation value)
        {
            cp.UpdateConsultation(value);
        }
    }
}