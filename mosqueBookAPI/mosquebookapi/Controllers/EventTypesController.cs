﻿using Microsoft.AspNetCore.Mvc;
using mosquebookapi.Data.Repositories.Abstraction;
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
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<EventTypes>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<EventTypes>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EventTypes>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EventTypes>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
