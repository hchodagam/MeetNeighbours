using meetneighbours.DTO;
using meetneighbours.services.contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace meetneighbours.web.Controllers
{
    [RoutePrefix("api/city")]
    public class CityController : ApiController
    {
        private ICityService _CityService;
        public CityController(ICityService CityService)
        {
            this._CityService = CityService;
        }
        [Route("GetAll")]
        public List<City> GetAll()
        {
            //return _securityrequest.GetMany(HttpContext.Current.Request.LogonUserIdentity.Name.Substring(3));
            return _CityService.getAllCities();
        }
    }
}
