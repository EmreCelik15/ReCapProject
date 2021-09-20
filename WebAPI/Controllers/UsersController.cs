using Business.Abstract;
using Core.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("add")]
        public IActionResult Add(User user)
        {
            _userService.Add(user);
            return Ok("Kullanıcı eklendi");
        }

        [HttpGet("getbymail")]
        public IActionResult GetByMail(string email)
        {
             _userService.GetByMail(email);
            return Ok("KUllanıcı getirildi");
        }

        [HttpGet("getclaim")]
        public IActionResult GetClaims(User user)
        {
            _userService.GetClaims(user);
            return Ok("Kullanıcı getirildi");
        }

        
    }
}
