

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace smokedmeats_server
{
    [Route("api/[controller]")]
    [ApiController]

    public class CooksController : ControllerBase
    {
        private readonly CooksService _cs;

        public CooksController(CooksService cs)
        {
            _cs = cs;
        }

        // get for all cooks
        [HttpGet]

        public ActionResult<IEnumerable<Cook>> GetCooks()
        {
            try
            {
                return Ok(_cs.GetCooks());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<Cook>> GetById(int id)
        {
            try
            {
                Cook found = _cs.GetById(id);
                return Ok(found);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [Authorize]
        public async Task<ActionResult<Cook>> Post([FromBody] Cook newCook)
        {
            try
            {
                Profile userInfo = await HttpContext

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }




    }
}