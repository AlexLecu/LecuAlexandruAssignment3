using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Assignment3.Models;
using Assignment3.Providers;

namespace Assignment3.Controllers
{
    [RoutePrefix("api/Secretary")]
    public class SecretaryController : ApiController
    {
        // GET: Secretary
        /* public ActionResult Index()
         {
             return View();
         }
         */
        SecretaryProvider sp = new SecretaryProvider();
        PatientProvider pp = new PatientProvider();
        ConsultationProvider cc = new ConsultationProvider();

        public IEnumerable<Patient> Get()
        {
            return pp.RetrievePatient();
        }

        // POST: api/Secretary
        public void Post([FromBody]Patient value)
        {
            pp.AddPatient(value);
        }

        // PUT: api/Secretary
        public void Put([FromBody]Patient value)
        {
            pp.UpdatePatient(value);
        }

        [Route("GetConsultation")]
        public IEnumerable<Consultation> GetConsultation()
        {
            return cc.RetrieveConsultation();
        }

        // POST: api/Secretary/AddConsultation
        [Route("AddConsultation")]
        public void PostConsultation([FromBody]Consultation consultation)
        {
            cc.AddConsultation(consultation);
        }

        // PUT: api/Secretary/UpdateConsultation
        [Route("UpdateConsultation")]
        public void PutConsultation([FromBody]Consultation consultation)
        {
            cc.UpdateConsultation(consultation);
        }

        // DELETE: api/Secretary/DeleteConsultation
        [Route("DeleteConsultation/{id}")]
        public void DeleteConsultation(int id)
        {
            cc.DeleteConsultation(id);
        }
    }
}