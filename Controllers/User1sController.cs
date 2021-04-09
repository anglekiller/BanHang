using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BanHang.CrudData;

namespace BanHang.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class User1sController : ControllerBase
    {
        private IUsers _user;
        public User1sController(IUsers user)
        {
            _user = user;
        }
        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetUsers()
        {
            return Ok(_user.GetUsers()) ;
        }

    }
}
