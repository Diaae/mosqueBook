using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using mosquebookapi.Dto;
using mosquebookapi.Helpers;
using mosquebookapi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mosquebookapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly TemporaryAuthenticator _temporaryAuthenticator;

        public UsersController(TemporaryAuthenticator temporaryAuthenticator)
        {
            _temporaryAuthenticator = temporaryAuthenticator;
        }

        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody]AuthenticateRequest model)
        {
            var response = _temporaryAuthenticator.Auth(model.Username,model.Password);

            if (string.IsNullOrEmpty(response))
                return BadRequest(new { message = "Username or password is incorrect" });

            return Ok(new { token = response });
        }

        [HttpPost("validate/{token}")]
        public IActionResult ValidateToken([FromRoute] Guid token)
        {
            var isValid = _temporaryAuthenticator.ValidateToken(token);

            if (!isValid)
                return Unauthorized(new { message = "Invalid token" });

            return Ok();
        }
        //[HttpPost("register")]
        //public IActionResult Register(UserDto model)
        //{
        //    var response = _userService.Authenticate(model);

        //    if (response == null)
        //        return BadRequest(new { message = "Username or password is incorrect" });

        //    return Ok(response);
        //}

    }
}
