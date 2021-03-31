using Microsoft.AspNetCore.Mvc;
using mosquebookapi.Data.Repositories.Abstraction;
using mosquebookapi.Models;
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
        private readonly IEventRepository _eventRepository;
        public EventsController(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }

        // GET: api/<EventsController>
        [HttpGet]
        public IEnumerable<Event> Get()
        {
            return _eventRepository.ListAll();
        }

        // GET api/<EventsController>/5
        [HttpGet("{id}")]
        public Event Get(Guid id)
        {
            return _eventRepository.FindById(id);
        }


        // PUT api/<EventsController>/5
        [HttpPut("{id}")]
        public IActionResult Put([FromRoute] Guid id, [FromBody] Event @event)
        {
            if (id != @event.Id)
            {
                return BadRequest();
            }

            @event.Id = id;
            try
            {
                _eventRepository.Save(@event);
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
        public void Delete(Guid id)
        {
            _eventRepository.Delete(id);
        }
    }
}
