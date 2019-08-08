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
    public class DepartmentsController : ApiController
    {
        readonly IDepartmentService _iDepartmentService;

        public DepartmentsController() { }

        public DepartmentsController(IDepartmentService iDepartmentService)
        {
            _iDepartmentService = iDepartmentService;
        }

        //GET: api/Departments
        public HttpResponseMessage GetDepartments()
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Data Not Found in Database");
            var get = _iDepartmentService.Get();
            if (get != null)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, get);
                return message;
            }
            return message;
        }

        //GET: api/Departments/5
        public HttpResponseMessage GetDepartment(int id)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Invalid Id");
            var get = _iDepartmentService.Get(id);
            if (get != null)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, get);
                return message;
            }
            return message;
        }

        // PUT: api/Departments/5
        [HttpPut]
        public HttpResponseMessage UpdateDepartment(int id, DepartmentVM departmentVM)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Bad Request");
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Invalid Id");
            }
            else
            {
                var get = _iDepartmentService.Update(id, departmentVM);
                if (get)
                {
                    message = Request.CreateResponse(HttpStatusCode.OK, get);
                    return message;
                }
            }
            return message;
        }

        // POST: api/Departments
        public HttpResponseMessage InsertDepartment(DepartmentVM departmentVM)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Wrong Parameter");
            var result = _iDepartmentService.Insert(departmentVM);
            if (result)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, "Successfully Added");
            }
            return message;
        }

        // DELETE: api/Provinces/5
        [HttpDelete]
        public HttpResponseMessage DeleteDepartment(int id)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Bad Request");
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Invalid Id");
            }
            else
            {
                var result = _iDepartmentService.Delete(id);
                if (result)
                {
                    message = Request.CreateResponse(HttpStatusCode.OK);
                }
            }
            return message;
        }
    }
}