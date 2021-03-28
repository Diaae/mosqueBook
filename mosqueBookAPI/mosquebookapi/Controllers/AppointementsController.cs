using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using mosquebookapi.Dto;
using mosquebookapi.Services;
using mosquebookapi.Services.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mosquebookapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointementsController : ControllerBase
    {
        private readonly IAppointmentManager _appointmentManager;
        public AppointementsController(IAppointmentManager appointmentManager)
        {
            _appointmentManager = appointmentManager;
        }
        [HttpPost]
        public IActionResult SaveAppointement(UserAppointmentDto userAppointementDto)
        {

            _appointmentManager.CreateAppointment(userAppointementDto);

            return Ok();
        }
        [HttpGet("/{appointmentId}")]
        public IActionResult GetAppointement([FromRoute]Guid appointmentId)
        {

           var userAppointementDto = _appointmentManager.GetAppointment(appointmentId);

            return Ok(userAppointementDto);
        }
    }
}
