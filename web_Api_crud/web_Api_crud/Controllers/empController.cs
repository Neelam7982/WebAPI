using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using web_Api_crud.db_context;
using web_Api_crud.Models;

namespace web_Api_crud.Controllers
{

    public class empController : ApiController
    {
        [HttpGet]
        [Route("emp/getemployee")]
        // GET api/<controller>
        public List<Table_Emp> getname()
        {
            List<employeemodel> listemp = new List<employeemodel>();

            empEntities objlist = new empEntities();

            var res = objlist.Table_Emp.ToList();

            return res;
        }

        [HttpPost]
        [Route("emp/saveEmployee")]
        public List<string> saveemp()
        {

            List<string> obj = new List<string>()
            {
                "neelam",
                "rohit",
                "vikas"

            };


            return obj;
        }
    }
}