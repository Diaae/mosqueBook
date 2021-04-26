using Microsoft.AspNetCore.Mvc;
using mosquebookapi.Dto;
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
    public class AppointmentsController : ControllerBase
    {
        private readonly AppointmentService _appointmentService;

        public AppointmentsController(AppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }
        // GET: api/<AppointmentController>
        [HttpGet("groupId/{groupId}")]
        public IEnumerable<AppointmentDto> ListByGroupId(Guid groupId)
        {
            return _appointmentService.ListAllByGroupId(groupId);
        }// GET: api/<AppointmentController>
        [HttpGet("event/{eventId}/group/{groupId}")]
        public IEnumerable<AppointmentDto> ListByGroupAndEvent(Guid groupId,Guid eventId)
        {
            return _appointmentService.ListByGroupAndEvent(groupId, eventId);
        }

        // GET api/<AppointmentController>/5
        [HttpGet("{tokenId}")]
        public IActionResult GetByToken(Guid tokenId)
        {
            var appointment = _appointmentService.FindByToken(tokenId);
            if(appointment == null)
            {
                NotFound();
            }
            return Ok(appointment);
        }

        // GET api/<AppointmentController>/5
        [HttpGet("/user/phonenumber/{phoneNumber}")]
        public IActionResult GetByUserPhoneNumber(string phoneNumber)
        {
            var appointment = _appointmentService.FindByUserPhoneNumber(phoneNumber);
            if (appointment == null)
            {
                NotFound();
            }
            return Ok(appointment);
        }
        // POST api/<AppointmentController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] AppointmentDto appointmentDto)
        {
            
            if(appointmentDto.User == null | appointmentDto.Group == null || appointmentDto.Group.Id == Guid.Empty)
            {
                return BadRequest();
            }
            try
            {
                await _appointmentService.BookAppointment(appointmentDto);
            }catch(Microsoft.EntityFrameworkCore.DbUpdateException dbException)
            {
                if (dbException.InnerException != null && dbException.InnerException.Message.Contains("IX_Appointment_EventId_UserId"))
                {
                    return StatusCode(500, new
                    {
                        code = "UserAlreadyHaveAppointment"
                    });
                }
                else
                {
                    return StatusCode(500, new
                    {
                        code = "Error",
                        dbException.InnerException.Message
                    }) ;
                }
            
            }
            catch (Exception e)
            {
                return StatusCode(500, new
                {
                    e.Message
                });
            }
            return Ok();
        }

        // PUT api/<AppointmentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AppointmentController>/5
        [HttpDelete("{id}")]
        public async void Delete(Guid id)
        {
            await _appointmentService.Remove(id);
        }
    }
}
