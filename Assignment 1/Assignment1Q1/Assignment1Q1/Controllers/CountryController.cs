using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Assignment1Q1.Models;



namespace Assignment1Q1.Controllers
{
    [RoutePrefix("api/Country")]
    public class CountryController : ApiController
    {
        public List<Country> countries = new List<Country>()
        {
            new Country{id=1, countryname="India", captial="Delhi"},
            new Country{id=2, countryname="USA", captial="Washington DC"},
            new Country{id=3, countryname="Pakistan", captial="Karachi"},
            new Country{id=4, countryname="Auustralia", captial="Syndey"},
            new Country{id=5, countryname="England", captial="Londan"}

        };
        [HttpGet]
        [Route("countrydetails")]

        public IEnumerable<Country> Get()
        {
            return countries;

        }

        [HttpGet]
        [Route("country/{id}")]
        public HttpResponseMessage Get(int id)
        {
             var countobj = countries.Find(x => x.id == id);
            if (countobj != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, countobj);
            }
            else
                return Request.CreateResponse(HttpStatusCode.NotFound,countobj);
        }

        public Country Post([FromBody]Country c)
        {
            countries.Add(c);
            return c;

        }

         //public IEnumerable<Country> Put(int id, [FromBody] Country )


        [HttpDelete]
        [Route("deletecountry/{id}")]
        public IHttpActionResult Delete(int id)
        {
            Country obj = countries.Find(x => x.id == id);
            if (obj != null)
            {
                bool isremoved = countries.Remove(obj);
                if (isremoved)
                {
                    return Ok(obj);
                }
                
            }
            return NotFound();
        }

        public IEnumerable<Country> Put(int id,[FromBody]Country country)
        {
            countries[id - 1] = country;
            return countries;
        }
        

    }
}
