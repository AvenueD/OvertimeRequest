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
    public class DistrictsController : ApiController
    {
        readonly IDistrictService _iDistrictService;

        public DistrictsController() { }

        public DistrictsController(IDistrictService iDistrictService)
        {
            _iDistrictService = iDistrictService;
        }

        //GET: api/Districts
        public HttpResponseMessage GetDistricts()
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Data Not Found in Database");
            var get = _iDistrictService.Get();
            if (get != null)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, get);
                return message;
            }
            return message;
        }

        //GET: api/Districts/5
        public HttpResponseMessage GetDistrict(int id)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Invalid Id");
            var get = _iDistrictService.Get(id);
            if (get != null)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, get);
                return message;
            }
            return message;
        }

        // PUT: api/Districts/5
        [HttpPut]
        public HttpResponseMessage UpdateDistrict(int id, DistrictVM districtVM)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Bad Request");
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Invalid Id");
            }
            else
            {
                var get = _iDistrictService.Update(id, districtVM);
                if (get)
                {
                    message = Request.CreateResponse(HttpStatusCode.OK, get);
                    return message;
                }
            }
            return message;
        }

        // POST: api/Districts
        public HttpResponseMessage InsertDistrict(DistrictVM districtVM)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Wrong Parameter");
            var result = _iDistrictService.Insert(districtVM);
            if (result)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, "Successfully Added");
            }
            return message;
        }

        // DELETE: api/Districts/5
        [HttpDelete]
        public HttpResponseMessage DeleteDistrict(int id)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Bad Request");
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Invalid Id");
            }
            else
            {
                var result = _iDistrictService.Delete(id);
                if (result)
                {
                    message = Request.CreateResponse(HttpStatusCode.OK);
                }
            }
            return message;
        }
    }
}