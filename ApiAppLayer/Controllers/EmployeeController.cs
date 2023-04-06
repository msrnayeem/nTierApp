using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiAppLayer.Controllers
{
    public class EmployeeController : ApiController
    {
        [HttpGet]
        [Route("api/employee/getAllEmployees")]
        public HttpResponseMessage GetAllEmployees()
        {
            try {
                var data = EmployeeServices.GetAll();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch(Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            
        }
    }
}
