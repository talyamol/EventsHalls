using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Solid.Core.DTOs;
using Solid.Core.Entities;
using Solid.Core.Services;
using Solid.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HallsEvents.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HallsController : ControllerBase
    {
        private readonly IHallsService _hallsService;
        private readonly IMapper _mapper;
        public HallsController(IHallsService hallsService,IMapper mapper)
        {
            _hallsService = hallsService;
            _mapper = mapper;
        }

        // GET: api/<HallsController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_hallsService.GetHallsAsync());
        }

        // GET api/<HallsController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Halls>> Get(int id)
        {
            var list = await _hallsService.GetByIdAsync(id);
            return Ok(list);
            //_mapper.Map<IEnumerable<HallsDTO>>(list)
        }

        // POST api/<HallsController>
        [HttpPost]
        public void Post([FromBody] Halls h)
        {
            _hallsService.AddHallsAsync(h);
        }

        // PUT api/<HallsController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Halls>> Put(int id, [FromBody] Halls hall)
        {
            var h = await _hallsService.GetByIdAsync(id);
            if (h is null)
            {
                return NotFound();
            }
            return Ok(_hallsService.UpdateHallsAsync(id, hall));
        }

        // DELETE api/<HallsController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var eve = await _hallsService.GetByIdAsync(id);
            if (eve is null)
            {
                return NotFound();
            }
            await _hallsService.DeleteHallsAsync(id);
            return NoContent();
        }
    }
}

