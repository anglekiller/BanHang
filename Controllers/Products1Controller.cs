using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BanHang.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Products1Controller : ControllerBase
    {
         public Products1Controller() { }
        [HttpGet]
        [Route("api/[controller]")]
        public string getProduct()
        {
            return "hahha";
        }
    }
}
