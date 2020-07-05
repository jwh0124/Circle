using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CirclePrototype.Models;
using CirclePrototype.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CirclePrototype.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody] User model)
        {
            var user = _userRepository.Authenticate(model.UserName, model.Password);
            if(user == null)
            {
                return BadRequest(new { message = "Username or password is incorrect" });
            }

            return Ok(user);
        }

        [AllowAnonymous]
        [HttpPost("register")]
        public IActionResult Register([FromBody] User model)
        {
            bool isExistUser = _userRepository.IsUniqueUser(model.UserName);
            if (!isExistUser)
            {
                return BadRequest(new { message = "UserName already exists" });
            }

            var user = _userRepository.Register(model.UserName, model.Password);
            if(user == null)
            {
                return BadRequest(new { message = "Error while registering" });
            }
            return Ok();
        }
    }
}