using meetneighbours.services.contracts;
using meetneighbours.DTO;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace meetneighbours.web.Controllers
{
    [RoutePrefix("api/businesslist")]
    public class BusinessListsController : ApiController
    {
        private IBusinessListService _BusinessListService;
        public BusinessListsController(IBusinessListService BusinessListService)
        {
            this._BusinessListService = BusinessListService;
        }
        [Route("GetAll")]
        public List<BusinessLists> GetAll()
        {
            //return _securityrequest.GetMany(HttpContext.Current.Request.LogonUserIdentity.Name.Substring(3));
            return _BusinessListService.GetAllBusinessLists();
        }

        [Route("AddBusinessList")]
        public void AddBusinessList()
        {
            
        }
    }
}
