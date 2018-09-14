using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AngularWebAPI.Controllers
{
    public class EmployeeController : ApiController
    {
        public IEnumerable<tblEmployee> Get()
        {
            using (AngularWebAPIEntities dbcontext = new AngularWebAPIEntities())
            {
                return dbcontext.tblEmployees.ToList();
            }
        }
        public tblEmployee Get(string id)
        {
            using (AngularWebAPIEntities dbcontext = new AngularWebAPIEntities())
            {
                return dbcontext.tblEmployees.FirstOrDefault(x=>x.Id==id);
            }
        }

    }
}
