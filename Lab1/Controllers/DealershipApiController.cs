// I, Aaron Soulliere, student number 000076628, certify that this material is my
// original work. No other person's work has been used without due
// acknowledgement and I have not made my work available to anyone else.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab1.Data;
using Lab1.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lab1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DealershipApiController : ControllerBase
    {
        // GET: api/DealershipApi
        [HttpGet]
        [Authorize(Roles = "Manager, Employee")]
        public IActionResult Get()
        {
            var dealerships = DealershipMgr.GetDealerships();
            if (dealerships == null)
            {
                return NotFound();
            }

            return Ok(dealerships);
        }

        // GET: api/DealershipApi/5
        [HttpGet("{id}", Name = "Get")]
        [Authorize(Roles = "Manager, Employee")]
        public IActionResult Get(int id)
        {
            var dealership = DealershipMgr.GetDealership(id);
            if (dealership == null)
            {
                return NotFound();
            }

            return Ok(dealership);
        }

        // POST: api/DealershipApi
        [HttpPost]
        [Authorize(Roles = "Manager, Employee")]
        public IActionResult Post([FromBody] Dealership value)
        {
            if (value == null)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (!DealershipMgr.CreateDealership(value))
            {
                ModelState.AddModelError("Error", "Error adding new Dealership.");
                return BadRequest(ModelState);
            }

            return CreatedAtRoute("Get", new { id = value.ID }, value);
        }

        // PUT: api/DealershipApi/5
        [HttpPut("{id}")]
        [Authorize(Roles = "Manager")]
        public IActionResult Put(int id, [FromBody] Dealership value)
        {
            if (value == null)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Dealership dealership = DealershipMgr.GetDealership(id);
            if (dealership == null)
            {
                return NotFound();
            }

            if (!DealershipMgr.UpdateDealership(value))
            {
                ModelState.AddModelError("Error", "Error updating Dealership.");
                return BadRequest(ModelState);
            }

            return NoContent();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        [Authorize(Roles = "Manager")]
        public IActionResult Delete(int id)
        {
            Dealership dealership = DealershipMgr.GetDealership(id);
            if (dealership == null)
            {
                return NotFound();
            }

            if (!DealershipMgr.DeleteDealership(dealership))
            {
                ModelState.AddModelError("Error", "Error deleting Dealership.");
                return BadRequest(ModelState);
            }

            return NoContent();
        }
    }
}
