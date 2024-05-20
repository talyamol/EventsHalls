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
    public class InvitedController : ControllerBase
    {
        private readonly IInvitedService _invitedService;
        private readonly IMapper _mapper;
        public InvitedController(IInvitedService invitedService, IMapper mapper)
        {
            _invitedService = invitedService;
            _mapper = mapper;
        }
        // GET: api/<InvitedController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_invitedService.GetInvitedAsync());
        }

        // GET api/<InvitedController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Invited>> Get(int id)
        {
            var list = await _invitedService.GetByIdAsync(id);
            return Ok(list);
        }

        // POST api/<InvitedController>
        [HttpPost]
        public void Post([FromBody] Invited invited)
        {
            _invitedService.AddInvitedAsync(invited);
        }

        // PUT api/<InvitedController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Invited>> Put(int id, [FromBody] Invited invited)
        {
            var i = await _invitedService.GetByIdAsync(id);
            if (i is null)
            {
                return NotFound();
            }
            return Ok(_invitedService.UpdateInvitedAsync(id, invited));
        }

        // DELETE api/<InvitedController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Invited>> Delete(int id)
        {
            var eve = await _invitedService.GetByIdAsync(id);
            if (eve is null)
            {
                return NotFound();
            }
            await _invitedService.DeleteInvitedAsync(id);
            return Ok();
        }
    }
}
