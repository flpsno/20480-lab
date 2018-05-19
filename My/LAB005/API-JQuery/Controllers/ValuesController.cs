using API_JQuery.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API_JQuery.Controllers
{
    public class ValuesController : ApiController
    {
        List<string> times = new List<string>();

        public ValuesController()
        {
            if (times.Count == 0)
            {
                times.Add("Santos");
                times.Add("Palmeiras");
                times.Add("São Paulo");
                times.Add("Corinthias");
                times.Add("Flamengo");
                times.Add("Grêmio");
                times.Add("Atl. Mineiro");
            }
        }


        public IEnumerable<string> Get()
        {
            return times;
        }

        // GET api/values/5
        public List<Partida> Get(string id)
        { 
            Contexto contexto = new Contexto();
           // return times.FirstOrDefault(x=> x == id);
            return contexto.Partida.ToList();
        }

        // POST api/values
        public void Post([FromBody]Partida value)
        {
            Contexto contexto = new Contexto();
            contexto.Partida.Add(value);
            contexto.SaveChanges();
            //Debug.WriteLine(mandante + " " + visitante + " " + data + " " + estadio);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {


        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}