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
    public class EventGroupsController : ControllerBase
    {
        private readonly EventGroupService _eventGroupService;
        public EventGroupsController(EventGroupService eventGroupService)
        {
            _eventGroupService = eventGroupService;
        }

        // GET: api/<EventsController>
        [HttpGet]
        public async Task<IEnumerable<EventGroupDto>> Get()
        {
            return await _eventGroupService.ListAll();
        }

        // GET api/<EventsController>/5
        [HttpGet("{id}")]
        public async Task<EventGroupDto> Get(Guid id)
        {
            return await _eventGroupService.FindById(id);
        }


        // PUT api/<EventsController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromRoute] Guid id, [FromBody] EventGroupDto eventGroupDto)
        {
            if (id != eventGroupDto.Id || !ModelState.IsValid)
            {
                return BadRequest();
            }

            eventGroupDto.Id = id;
            try
            {
                var result = await _eventGroupService.Save(eventGroupDto);
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

        // DELETE api/<EventsController>/5
        [HttpDelete("{id}")]
        public async Task Delete(Guid id)
        {

            await _eventGroupService.Remove(id);
        }
    }
}
