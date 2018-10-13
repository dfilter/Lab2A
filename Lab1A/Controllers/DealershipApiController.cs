// I, Dirk Filter, student number 000383606, certify that this material is my
// original work. No other person's work has been used without due
// acknowledgement and I have not made my work available to anyone else.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab1A.Data;
using Lab1A.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lab1A.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DealershipApiController : ControllerBase
    {
        // GET: api/DealershipApi
        [HttpGet]
        public List<Dealership> Get()
        {
            return DealershipMgr.getDealerships();
        }

        // GET: api/DealershipApi/5
        [HttpGet("{id}", Name = "Get")]
        public Dealership Get(int id)
        {
            return DealershipMgr.getDealership(id);
        }

        // POST: api/DealershipApi
        [HttpPost]
        public void Post([FromBody] Dealership value)
        {
            DealershipMgr.postDealership(value);
        }

        // PUT: api/DealershipApi/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Dealership value)
        {
            DealershipMgr.putDealership(id, value);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            DealershipMgr.deleteDealership(id);
        }
    }
}
