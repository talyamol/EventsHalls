using Microsoft.AspNetCore.Mvc;
using Solid.Core.Entities;
using Solid.Core.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HallsEvents.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HallsController : ControllerBase
    {
        private readonly IHallsService _hallsService;
        public HallsController(IHallsService hallsService)
        {
            _hallsService = hallsService;
        }

        // GET: api/<HallsController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_hallsService.GetHalls());
        }

        // GET api/<HallsController>/5
        [HttpGet("{id}")]
        public ActionResult<Halls> Get(int id)
        {
            return _hallsService.GetById(id);
        }

        // POST api/<HallsController>
        [HttpPost]
        public void Post([FromBody] Halls h)
        {
            _hallsService.AddHalls(h);
        }

        // PUT api/<HallsController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Halls hall)
        {
            return Ok(_hallsService.UpdateHalls(id, hall));
        }

        // DELETE api/<HallsController>/5
        [HttpDelete("{id}")]
        public ActionResult<Halls> Delete(int id)
        {
            _hallsService.DeleteHalls(id);
            return Ok();
        }
    }
}

