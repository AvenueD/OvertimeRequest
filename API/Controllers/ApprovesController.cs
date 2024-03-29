﻿using BusinessLogic.Services.Interfaces;
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
    public class ApprovesController : ApiController
    {
      
            readonly IApproveService _iApproveService;
            public ApprovesController() { }
            public ApprovesController(IApproveService iApproveService)
            {
                _iApproveService = iApproveService;
            }
            //GET : api/Approve
            public HttpResponseMessage GetApproves()
            {
                var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Data Not Found in The Database");
                var get = _iApproveService.Get();
                if (get != null)
                {
                    message = Request.CreateResponse(HttpStatusCode.OK, get);
                    return message;
                }
                return message;
            }
            //GET : api/Approves/5
            public HttpResponseMessage GetApprove(int id)
            {
                var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Invalid Id");
                var get = _iApproveService.Get(id);
                if (get != null)
                {
                    message = Request.CreateResponse(HttpStatusCode.OK, get);
                    return message;
                }
                return message;
            }
            [HttpPut]
            public HttpResponseMessage UpdateApprove(int id, ApproveVM approveVM)
            {
                var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Bad Request");
                if (string.IsNullOrWhiteSpace(id.ToString()))
                {
                    message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Invalid Id");
                }
                else
                {
                    var get = _iApproveService.Update(id, approveVM);
                    if (get)

                    {
                        message = Request.CreateResponse(HttpStatusCode.OK, get);
                        return message;
                    }
                }
                return message;
            }
            public HttpResponseMessage InsertApprove(ApproveVM approveVM)
            {
                var message = Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Wrong Parameter");
                var result = _iApproveService.Insert(approveVM);
                if (result)
                {
                    message = Request.CreateResponse(HttpStatusCode.OK, "Successfully Added");

                }
                return message;
            }
            public HttpResponseMessage DeleteApprove(int id)
            {
                var message = Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Bad Request");
                if (string.IsNullOrWhiteSpace(id.ToString()))
                {
                    message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Invalid Id");
                }
                else
                {
                    var result = _iApproveService.Delete(id);
                    if (result)
                    {
                        message = Request.CreateResponse(HttpStatusCode.OK);
                    }
                }
                return message;
            }
            
        }
}