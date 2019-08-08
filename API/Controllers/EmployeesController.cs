using BusinessLogic.Services.Interfaces;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace API.Controllers
{
    public class EmployeesController : ApiController
    {
        readonly IEmployeeService _iEmployeeService;

        public EmployeesController() { }

        public EmployeesController(IEmployeeService iEmployeeService)
        {
            _iEmployeeService = iEmployeeService;
        }

        //GET: api/Employees
        public HttpResponseMessage GetEmployees()
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Data Not Found in Database");
            var get = _iEmployeeService.Get();
            if (get != null)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, get);
                return message;
            }
            return message;
        }

        //GET: api/Employees/5
        public HttpResponseMessage GetEmployee(int id)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Invalid Id");
            var get = _iEmployeeService.Get(id);
            if (get != null)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, get);
                return message;
            }
            return message;
        }

        // PUT: api/Employees/5
        [HttpPut]
        public HttpResponseMessage UpdateEmployee(int id, EmployeeVM employeeVM)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Bad Request");
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Invalid Id");
            }
            else
            {
                var get = _iEmployeeService.Update(id, employeeVM);
                if (get)
                {
                    message = Request.CreateResponse(HttpStatusCode.OK, get);
                    return message;
                }
            }
            return message;
        }

        // POST: api/Employees
        public HttpResponseMessage InsertEmployee(EmployeeVM employeeVM)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Wrong Parameter");
            var result = _iEmployeeService.Insert(employeeVM);
            if (result)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, "Successfully Added");
            }
            return message;
        }

        // DELETE: api/Provinces/5
        [HttpDelete]
        public HttpResponseMessage DeleteEmployee(int id)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Bad Request");
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Invalid Id");
            }
            else
            {
                var result = _iEmployeeService.Delete(id);
                if (result)
                {
                    message = Request.CreateResponse(HttpStatusCode.OK);
                }
            }
            return message;
        }
    }
}