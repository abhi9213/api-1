using api_1.dbfolder;
using api_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace api_1.Controllers
{
    public class myapiController : ApiController
    {
        [HttpGet]
        [Route("myapi/mygetemp")]
        public List<empmodelClass1> getemp()
        {
            List<empmodelClass1> lobj = new List<empmodelClass1>();
            mvcdatabEntities eobj = new mvcdatabEntities();
           var res= eobj.emptables.ToList();


            foreach (var item in res)
            {
                lobj.Add(new empmodelClass1
                {
                    id = item.id,
                    name = item.name,
                    email = item.email,
                    pass = item.pass
                });
            }


            return lobj;
        }
        [HttpPost]
        [Route("my/saveemp")]
        public List<string> saveemp()
        {
            List<string> obj = new List<string>();




            return obj;
        }
    }
}