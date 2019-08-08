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
    public class DivisionsController : ApiController
    {
        readonly IDivisionService _iDivisionService;
        public DivisionsController() { }
        public DivisionsController(IDivisionService iDivisionService)
        {
            _iDivisionService = iDivisionService;
        }
        //GET : api/Division
        public HttpResponseMessage GetDivisions()
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Data Not Found in The Database");
            var get = _iDivisionService.Get();
            if(get != null)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, get);
                return message;
            }
            return message;
        }
        //GET : api/Divisions/5
        public HttpResponseMessage  GetDivision(int id)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Invalid Id");
            var get = _iDivisionService.Get(id);
            if(get != null)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, get);
                return message;
            }
            return message;
        }
        [HttpPut]
        public HttpResponseMessage UpdateDivision(int id, DivisionVM divisionVM)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Bad Request");
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Invalid Id");
            }
            else
            {
                var get = _iDivisionService.Update(id, divisionVM);
                if (get)

                {
                    message = Request.CreateResponse(HttpStatusCode.OK, get);
                    return message;
                }
            }
            return message;
        }
        public HttpResponseMessage InsertDivision(DivisionVM divisionVM)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Wrong Parameter");
            var result = _iDivisionService.Insert(divisionVM);
            if(result)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, "Successfully Added");

            }
            return message;
        }
        public HttpResponseMessage DeleteDivision(int id)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Bad Request");
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Invalid Id");
            }
            else
            {
                var result = _iDivisionService.Delete(id);
                if (result)
                {
                    message = Request.CreateResponse(HttpStatusCode.OK);
                }
            }
            return message;
        }
        
    }
}