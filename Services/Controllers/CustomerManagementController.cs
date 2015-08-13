using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Services.Controllers
{
    public class CustomerManagementController : ApiController
    {
        // GET: api/CustomerManagement
        public HttpResponseMessage Get()
        {
            List<Customer> custs = new List<Customer>() {
                new Customer {
                    Id = 1,
                    FirstName = "Jan",
                    LastName = "Vogel",
                    CustomerType = CustomerType.Premium
                },
                new Customer {
                    Id = 2,
                    FirstName = "Peter",
                    LastName = "Vogel",
                    CustomerType = CustomerType.Standard
                }
            };
            //return new string[] { "value1", "value2" };
            HttpResponseMessage hrm = 
                this.Request.CreateResponse<
                    List<Customer>>(HttpStatusCode.OK, custs);
            return hrm;
        }

        // GET: api/CustomerManagement/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/CustomerManagement
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/CustomerManagement/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/CustomerManagement/5
        public void Delete(int id)
        {
        }
    }
}
