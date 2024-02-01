using Microsoft.AspNetCore.Mvc;
using Solid.Core.Entities;
using Solid.Core.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HallsEvents.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvitedController : ControllerBase
    {
        private readonly IInvitedService _invitedService;
        public InvitedController(IInvitedService invitedService)
        {
            _invitedService = invitedService;
        }
        // GET: api/<InvitedController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_invitedService.GetInvited());
        }

        // GET api/<InvitedController>/5
        [HttpGet("{id}")]
        public ActionResult<Invited> Get(int id)
        {
            return _invitedService.GetById(id);
        }

        // POST api/<InvitedController>
        [HttpPost]
        public void Post([FromBody] Invited invited)
        {
            _invitedService.AddInvited(invited);
        }

        // PUT api/<InvitedController>/5
        [HttpPut("{id}")]
        public ActionResult<Invited> Put(int id, [FromBody] Invited invited)
        {
            return Ok(_invitedService.UpdateInvited(id, invited));
        }

        // DELETE api/<InvitedController>/5
        [HttpDelete("{id}")]
        public ActionResult<Invited> Delete(int id)
        {
            _invitedService.DeleteInvited(id);
            return Ok();
        }
    }
}
