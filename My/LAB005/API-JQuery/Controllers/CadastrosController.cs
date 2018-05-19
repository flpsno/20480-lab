using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API_JQuery.Controllers
{
    public class CadastrosController : ApiController
    {
        public List<string> Get() {
            return new List<string>();
        }

        public void Post(string data
            , string mandante
            , string visitante
            , string estadio)
        {
            Debug.WriteLine(mandante + " " + visitante + " " + data + " " + estadio);
        }
    }
}
