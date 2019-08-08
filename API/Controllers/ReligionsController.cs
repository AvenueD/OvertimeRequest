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
    public class ReligionsController : ApiController
    {
        readonly IReligionService _iReligionService;

        public ReligionsController() { }

        public ReligionsController(IReligionService iReligionService)
        {
            _iReligionService = iReligionService;
        }

        //GET: api/Religions
        public HttpResponseMessage GetReligions()
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Data Not Found in Database");
            var get = _iReligionService.Get();
            if(get != null)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, get);
                return message;
            }
            return message;
        }

        //GET: api/Religions/5
        public HttpResponseMessage GetReligion(int id)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Invalid Id");
            var get = _iReligionService.Get(id);
            if (get != null)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, get);
                return message;
            }
            return message;
        }

        // PUT: api/Religions/5
        [HttpPut]
        public HttpResponseMessage UpdateReligion(int id, ReligionVM religionVM)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Bad Request");
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Invalid Id");
            }
            else
            {
                var get = _iReligionService.Update(id, religionVM);
                if (get)
                {
                    message = Request.CreateResponse(HttpStatusCode.OK, get);
                    return message;
                }
            }
            return message;
        }

        // POST: api/Religions
        public HttpResponseMessage InsertReligion(ReligionVM religionVM)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Wrong Parameter");
            var result = _iReligionService.Insert(religionVM);
            if (result)
            {
                message = Request.CreateResponse(HttpStatusCode.OK, "Successfully Added");
            }
            return message;
        }

        // DELETE: api/Provinces/5
        [HttpDelete]
        public HttpResponseMessage DeleteReligion(int id)
        {
            var message = Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Bad Request");
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                message = Request.CreateErrorResponse(HttpStatusCode.NotFound, "Invalid Id");
            }
            else
            {
                var result = _iReligionService.Delete(id);
                if (result)
                {
                    message = Request.CreateResponse(HttpStatusCode.OK);
                }
            }
            return message;
        }
    }
}