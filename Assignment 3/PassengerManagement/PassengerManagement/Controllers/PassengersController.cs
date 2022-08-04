using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PassengerManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PassengersController : ControllerBase
    {
        static List<PassengerModel> passengerlist = new List<PassengerModel>()
        {
            new PassengerModel{passID = 123, passname = "Kevin", passnumber = 1234567890 },
            new PassengerModel{ passID = 124, passname = "Sam", passnumber = 1234569877}
        };


        // GET: api/<PassengersController>
        [HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}
        public IEnumerable<PassengerModel> Get()
        {
            //PassengerModel PassengerModel1 = new PassengerModel() {  };
            //PassengerModel PassengerModel2 = new PassengerModel() { passID = 124, passname = "Sam", passnumber = 1234569877 };

            

           

            //List<PassengerModel> passengerlist = new List<PassengerModel>();
            //passengerlist.Add(PassengerModel1);
            //passengerlist.Add(PassengerModel2);

            return passengerlist;

        }

        // GET api/<PassengersController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PassengersController>
        [HttpPost]
        public IEnumerable<PassengerModel> Post([FromBody] PassengerModel passenger)
        {
            passengerlist.Add(passenger);
            return passengerlist;


        }

        // PUT api/<PassengersController>/5
        [HttpPut("{id}")]
        public PassengerModel Put(int id, [FromBody] PassengerModel passenger)
        {
            passengerlist[id - 1] = passenger;
            return passenger;
        }

        // DELETE api/<PassengersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            //passengerlist.RemoveAt(id - 1);
            //return passengerlist;
        }
    }
}
