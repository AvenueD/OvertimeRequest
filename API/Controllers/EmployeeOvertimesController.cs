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
    public class EmployeeOvertimesController : ApiController
    {
        readonly IEmployeeOvertimeService _iEmployeeOvertimeService;

        public EmployeeOvertimesController() { }

        public EmployeeOvertimesController(IEmployeeOvertimeService iEmployeeOvertimeService)
        {
            _iEmployeeOvertimeService = iEmployeeOvertimeService;
        }

        //GET: api/EmployeeOvertimes
        public HttpResponseMessage GetEmployeeOvertimes()
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Data Not Found in Database");
            var get = _iEmployeeOvertimeService.Get();
            if (get != null)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, get);
                return message;
            }
            return message;
        }

        //GET: api/EmployeeOvertimes/5
        public HttpResponseMessage GetEmployeeOvertime(int id)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Invalid Id");
            var get = _iEmployeeOvertimeService.Get(id);
            if (get != null)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, get);
                return message;
            }
            return message;
        }

        // PUT: api/EmployeeOvertimes/5
        /*public HttpResponseMessage UpdateEmployeeOvertime(int id, EmployeeOvertimeVM employeeOvertimeVM)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Bad Request");
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Invalid Id");
            }
            else
            {
                var get = _iEmployeeOvertimeService.Update(id, employeeOvertimeVM);
                if (get)
                {
                    message = Request.CreateResponse(HttpStatusCode.OK, get);
                    return message;
                }
            }
            return message;
        }*/

        // POST: api/EmployeeOvertimes
        public HttpResponseMessage InsertEmployeeOvertime(EmployeeOvertimeVM employeeOvertimeVM)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Wrong Parameter");
            var result = _iEmployeeOvertimeService.Insert(employeeOvertimeVM);
            if (result)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, "Successfully Added");
            }
            return message;
        }

        // DELETE: api/EmployeeOvertimes/5
        /*public HttpResponseMessage DeleteEmployeeOvertime(int id)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Bad Request");
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Invalid Id");
            }
            else
            {
                var result = _iEmployeeOvertimeService.Delete(id);
                if (result)
                {
                    message = Request.CreateResponse(HttpStatusCode.OK);
                }
            }
            return message;
        }*/
    }
}