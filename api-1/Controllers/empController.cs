using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace api_1.Controllers
{
    public class empController : ApiController
    {[HttpGet]
       public List<string> getempdetail()
        {
            List<string> lemp = new List<string>()
            {
                "abh",
                "saurav",
                "faiz"
            };
            return lemp;
        }
    }
}