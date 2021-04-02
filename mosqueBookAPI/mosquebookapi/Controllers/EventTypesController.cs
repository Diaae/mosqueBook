using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mosquebookapi.Dto;
using mosquebookapi.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace eventTypebookapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventTypesController : ControllerBase
    {
        private readonly EventTypeService _eventTypeService;
        public EventTypesController(EventTypeService eventTypeService)
        {
            _eventTypeService = eventTypeService;
        }
        [HttpGet]
        public async Task<IEnumerable<EventTypeDto>> Get()
        {
            return await _eventTypeService.ListAll();
        }

        // GET api/<MosqueController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var eventType = await _eventTypeService.FindById(id);
            if (eventType == null)
            {
                return NotFound();
            }
            return Ok(eventType);
        }



        // PUT api/<MosqueController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromRoute] Guid id, [FromBody] EventTypeDto eventTypeDto)
        {
            if (id != eventTypeDto.Id || !ModelState.IsValid)
            {
                return BadRequest();
            }
            try
            {
                int result = await _eventTypeService.Save(eventTypeDto);
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
                    message = e.InnerException.Message
                });
            }
        }

        // DELETE api/<MosqueController>/5
        [HttpDelete("{id}")]
        public async Task Delete(Guid id)
        {
            await _eventTypeService.Remove(id);
        }
    }
}
