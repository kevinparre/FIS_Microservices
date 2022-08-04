using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DriverManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriversController : ControllerBase
    {
        //DriverModel DriverModel1 = new DriverModel() ;
        //DriverModel DriverModel2 = new DriverModel();


        static List<DriverModel> driverlist = new List<DriverModel>() {
              new DriverModel{ driverID = 123, drivername = "Tim", drivernumber = 1234567890 },
             new DriverModel{ driverID = 124, drivername = "John", drivernumber = 1234569877 }
    };
        //driverlist.Add(DriverModel1);
        //    driverlist.Add(DriverModel2);


        // GET: api/<DriversController>

        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        [HttpGet]
        public IEnumerable<DriverModel> Get()
        {
           
            return driverlist;

        }


        // GET api/<DriversController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<DriversController>
        [HttpPost]
        public DriverModel Post([FromBody] DriverModel driver)
        {
            driverlist.Add(driver);
            return driver;
        }

        // PUT api/<DriversController>/5
        [HttpPut("{id}")]
        public IEnumerable<DriverModel> Put(int id, [FromBody]DriverModel driver )
        {
            driverlist[id - 1] = driver;
            return driverlist;

        }

        // DELETE api/<DriversController>/5
        [HttpDelete("{id}")]
        public IEnumerable<DriverModel> Delete(int id)
        {
            driverlist.RemoveAt(id - 1);
            return driverlist;
        }
    }
}
