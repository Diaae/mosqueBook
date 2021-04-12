using Microsoft.AspNetCore.Mvc;
using mosquebookapi.Data.Repositories.Interfaces;
using mosquebookapi.Dto;
using mosquebookapi.Models;
using mosquebookapi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace mosquebookapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly EventService _eventService;
        public EventsController(EventService eventService)
        {
            _eventService = eventService;
        }

        // GET: api/<EventsController>
        [HttpGet]
        public async Task<IEnumerable<EventDto>> Get()
        {
            return await _eventService.ListAll();
        }
        // GET: api/<EventsController>
       


        // GET api/<EventsController>/5
        [HttpGet("{eventTypeId}")]
        public IActionResult Get(Guid eventTypeId, [FromQuery]DateTime date)
        {
            var @event =  _eventService.FindByEventTypeIdAndDate(eventTypeId, date);
            if(@event == null)
            {
                return NotFound();
            }

            return Ok(@event);

        }


        // PUT api/<EventsController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromRoute] Guid id, [FromBody] EventDto @event)
        {
            if (id != @event.Id || !ModelState.IsValid)
            {
                return BadRequest();
            }

            @event.Id = id;
            try
            {
                var result = await _eventService.Save(@event);
                if (result < 1)
                {
                    return StatusCode(500, new
                    {
                        message = "Error while saving"
                    });
                }
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, new
                {
                    message = e.Message
                });
            }
        }

        // DELETE api/<EventsController>/5
        [HttpDelete("{id}")]
        public async Task Delete(Guid id)
        {

            await _eventService.Remove(id);
        }
    }
}
