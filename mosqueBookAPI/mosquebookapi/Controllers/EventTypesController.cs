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
    public class EventTypesController : ControllerBase
    {
        private readonly IEventTypeRepository _eventTypeRepository;
        public EventTypesController(IEventTypeRepository eventTypeRepository)
        {
            _eventTypeRepository = eventTypeRepository;
        }
        // GET: api/<EventTypes>
        [HttpGet]
        public IEnumerable<EventType> Get()
        {
            return _eventTypeRepository.ListAll();
        }

        // GET api/<EventTypes>/5
        [HttpGet("{id}")]
        public string Get(Guid id)
        {
            return "value";
        }


        // PUT api/<EventTypes>/5
        [HttpPut("{id}")]
        public IActionResult Put([FromRoute] Guid id, [FromBody] EventType eventType)
        {
            if(id != eventType.Id)
            {
                return BadRequest();
            }

            eventType.Id = id;
            try
            {
                _eventTypeRepository.Save(eventType);
                return Ok();
            }catch(Exception e)
            {
                return StatusCode(500, new
                {
                    message = e.InnerException.Message
                });
            }

        }

        // DELETE api/<EventTypes>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _eventTypeRepository.Delete(id);
        }
    }
}
