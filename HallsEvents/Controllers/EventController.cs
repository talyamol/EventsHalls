using Microsoft.AspNetCore.Mvc;
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
        public EventController(IEventService data)
        {
            _eventsService = data;
        }
        // GET: api/<EventController>
        [HttpGet]
        public IActionResult Get()
        {
            var list=_eventsService.GetEventsAsync();
            return Ok(list);
        }

        // GET api/<EventController>/5
        [HttpGet("{id}")]
        public ActionResult<Event> Get(int id)
        {
            //var eve = _eventsService.GetById(id);
            //if (eve==null) 
            //    return NotFound();
            //return Ok(eve);
            return _eventsService.GetById(id);
        }

        // POST api/<EventController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Event e)
        {
            var eventToAdd=new Event { Name = e.Name ,CountInvited=e.CountInvited,Date=e.Date,HallId=e.HallId,Id=e.Id,MinAge=e.MinAge,StartHour=e.StartHour};
           var newEvent=await _eventsService.AddEventsAsync(e);
            return Ok(newEvent);
        }

        // PUT api/<EventController>/5
        [HttpPut("{id}")]
        public ActionResult<Event> Put(int id, [FromBody] Event event1)
        {

            {
                return Ok(_eventsService.UpdateEvents(id, event1));
            }
        }

        // DELETE api/<EventController>/5
        [HttpDelete("{id}")]
        public ActionResult<Event> Delete(int id)
        {
            _eventsService.DeleteEvents(id);
            return Ok();
        }
    }
}

