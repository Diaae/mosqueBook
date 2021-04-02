using System;
using Microsoft.AspNetCore.Mvc;
using mosquebookapi.Dto;
using mosquebookapi.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace mosquebookapi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class MosquesController : ControllerBase
    {
        private readonly MosqueService _mosqueService;
        public MosquesController(
            MosqueService mosqueService)
        {
            _mosqueService = mosqueService;
        }


        // GET: api/<MosqueController>
        [HttpGet]
        public  async Task<IEnumerable<MosqueDto>> Get()
        {
            return await _mosqueService.ListAll();
        }

        // GET api/<MosqueController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var mosque = await _mosqueService.FindById(id);
            if (mosque == null)
            {
                return NotFound();
            }
            return Ok(mosque);
        }



        // PUT api/<MosqueController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromRoute] Guid id, [FromBody] MosqueDto mosqueDto)
        {
            if (id != mosqueDto.Id  ||  !ModelState.IsValid)
            {
                return BadRequest();
            }
            try
            {
               int result = await _mosqueService.Save(mosqueDto);
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
            await _mosqueService.Remove(id);
        }
    }
}
