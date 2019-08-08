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
    public class ProvincesController : ApiController
    {
        readonly IProvinceService _iProvinceService;

        public ProvincesController() { }

        public ProvincesController(IProvinceService iProvinceService)
        {
            _iProvinceService = iProvinceService;
        }

        //GET: api/Provinces
        public HttpResponseMessage GetProvinces()
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Data Not Found in Database");
            var get = _iProvinceService.Get();
            if (get != null)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, get);
                return message;
            }
            return message;
        }

        //GET: api/Provinces/5
        public HttpResponseMessage GetProvince(int id)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Invalid Id");
            var get = _iProvinceService.Get(id);
            if (get != null)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, get);
                return message;
            }
            return message;
        }

        // PUT: api/Provinces/5
        [HttpPut]
        public HttpResponseMessage UpdateProvince(int id, ProvinceVM provinceVM)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Bad Request");
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Invalid Id");
            }
            else
            {
                var get = _iProvinceService.Update(id, provinceVM);
                if (get)
                {
                    message = Request.CreateResponse(HttpStatusCode.OK, get);
                    return message;
                }
            }
            return message;
        }

        // POST: api/Provinces
        public HttpResponseMessage InsertProvince(ProvinceVM provinceVM)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Wrong Parameter");
            var result = _iProvinceService.Insert(provinceVM);
            if (result)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, "Successfully Added");
            }
            return message;
        }

        // DELETE: api/Provinces/5
        [HttpDelete]
        public HttpResponseMessage DeleteProvince(int id)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Bad Request");
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Invalid Id");
            }
            else
            {
                var result = _iProvinceService.Delete(id);
                if (result)
                {
                    message = Request.CreateResponse(HttpStatusCode.OK);
                }
            }
            return message;
        }
    }
}