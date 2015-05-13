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
    public class CategoryController : ApiController
    {
        private ICategoryService _CategoryService;
        private IBusinessListService _BusinessListService;
        public CategoryController(ICategoryService CategoryService, IBusinessListService BusinessListService)
        {
            this._CategoryService = CategoryService;
            this._BusinessListService = BusinessListService;
        }
        // GET: api/Category
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Category/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Category
        public void Post([FromBody]Category _Category)
        {
           _CategoryService.AddCategory(_Category);
           // _BusinessListService.AddBusinessList(_BusinessLists);
        }

        // PUT: api/Category/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Category/5
        public void Delete(int id)
        {
        }
    }
}
