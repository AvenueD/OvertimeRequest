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
    public class OvertimeRequestsController : ApiController
    {
        readonly IOvertimeRequestService _iOvertimeRequestService;

        public OvertimeRequestsController() { }

        public OvertimeRequestsController(IOvertimeRequestService iOvertimeRequestService)
        {
            _iOvertimeRequestService = iOvertimeRequestService;
        }

        //GET: api/OvertimeRequests
        public HttpResponseMessage GetOvertimeRequests()
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Data Not Found in Database");
            var get = _iOvertimeRequestService.Get();
            if (get != null)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, get);
                return message;
            }
            return message;
        }

        //GET: api/OvertimeRequests/5
        public HttpResponseMessage GetOvertimeRequest(int id)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Invalid Id");
            var get = _iOvertimeRequestService.Get(id);
            if (get != null)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, get);
                return message;
            }
            return message;
        }

        // PUT: api/OvertimeRequests/5
        [HttpPut]
        public HttpResponseMessage UpdateOvertimeRequest(int id, OvertimeRequestVM overtimeRequestVM)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Bad Request");
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Invalid Id");
            }
            else
            {
                var get = _iOvertimeRequestService.Update(id, overtimeRequestVM);
                if (get)
                {
                    message = Request.CreateResponse(HttpStatusCode.OK, get);
                    return message;
                }
            }
            return message;
        }

        // POST: api/OvertimeRequests
        public HttpResponseMessage InsertOvertimeRequest(OvertimeRequestVM overtimeRequestVM)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Wrong Parameter");
            var result = _iOvertimeRequestService.Insert(overtimeRequestVM);
            if (result)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, "Successfully Added");
            }
            return message;
        }

        // DELETE: api/Provinces/5
        public HttpResponseMessage DeleteOvertimeRequest(int id)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Bad Request");
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Invalid Id");
            }
            else
            {
                var result = _iOvertimeRequestService.Delete(id);
                if (result)
                {
                    message = Request.CreateResponse(HttpStatusCode.OK);
                }
            }
            return message;
        }
    }
}
