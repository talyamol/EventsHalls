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
    public class EventController : ControllerBase
    {
        private readonly IEventService _eventsService;
        private readonly IMapper _mapper;
        public EventController(IEventService data, IMapper mapper)
        {
            _eventsService = data;
            _mapper = mapper;
        }
        // GET: api/<EventController>
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var list = _eventsService.GetEventsAsync();
            return Ok(list);
        }

        // GET api/<EventController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Event>> Get(int id)
        {
            var list = await _eventsService.GetByIdAsync(id);
            return Ok(_mapper.Map<IEnumerable<EventDTO>>(list));
           
        }

        // POST api/<EventController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Event e)
        {
            var eventToAdd = new Event { Name = e.Name, CountInvited = e.CountInvited, Date = e.Date, HallId = e.HallId, Id = e.Id, MinAge = e.MinAge, StartHour = e.StartHour };
            var newEvent = await _eventsService.AddEventsAsync(e);
            return Ok(newEvent);
        }

        // PUT api/<EventController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Event>> Put(int id, [FromBody] Event event1)
        {
            var eve = await _eventsService.GetByIdAsync(id);
            if (eve is null)
            {
                return NotFound();
            }
            return Ok(_eventsService.UpdateEventsAsync(id, event1));
        }

        // DELETE api/<EventController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var eve = await _eventsService.GetByIdAsync(id);
            if (eve is null)
            {
                return NotFound();
            }
            await _eventsService.DeleteEventsAsync(id);
            return NoContent();
        }
    }
}

