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

        [HttpGet]
        [Route("api/employee/getEmployeeById/{id}")]
        public HttpResponseMessage GetEmployeeById(int id)
        {
            try
            {
                var data = EmployeeServices.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }


        [HttpPost]
        [Route("api/employee/addEmployee")]
        public HttpResponseMessage AddEmployee(EmployeeServices employee)
        {
            //try
            //{
            //    bool result = EmployeeServices.Create(employee);
            //    if (result)
            //    {
            //        return Request.CreateResponse(HttpStatusCode.OK, "inserted");
            //    }
            //    else
            //    {
            //        return Request.CreateResponse(HttpStatusCode.NotModified, "failed");
            //    }

            //}
            //catch (Exception ex)
            //{
            //    return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            //}
            return Request.CreateResponse(HttpStatusCode.OK, employee);
        }
    }
}
