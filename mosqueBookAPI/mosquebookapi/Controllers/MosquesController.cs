using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using mosquebookapi.Data.Repositories.Abstraction;
using mosquebookapi.Dto;
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
    public class MosquesController : ControllerBase
    {
        private readonly IMosqueRepository _mosqueRepository;
        private readonly IMapper _autoMapper;
        public MosquesController(IMosqueRepository mosqueRepository,IMapper mapper)
        {
            _mosqueRepository = mosqueRepository;
            _autoMapper = mapper;
        }


        // GET: api/<MosqueController>
        [HttpGet]
        public IEnumerable<MosqueDto> Get()
        {
            var mosques = _mosqueRepository.ListAll();
            
            return _autoMapper.Map<IEnumerable<MosqueDto>>(mosques);
        }

        // GET api/<MosqueController>/5
        [HttpGet("{id}")]
        public Mosque Get(Guid id)
        {
            return _mosqueRepository.FindById(id);
        }



        // PUT api/<MosqueController>/5
        [HttpPut("{id}")]
        public  IActionResult Put(Guid id, [FromBody] MosqueDto mosqueDto)
        {
            if (id != mosqueDto.Id)
            {
                return BadRequest();
            }

            var mosque = _autoMapper.Map<Mosque>(mosqueDto);

            mosque.Id = id;
            try
            {
                 
                 _mosqueRepository.Save(mosque);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500,new { 
                    message = e.InnerException.Message
                });
            }
        }

        // DELETE api/<MosqueController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _mosqueRepository.Delete(id);
        }
    }
}
