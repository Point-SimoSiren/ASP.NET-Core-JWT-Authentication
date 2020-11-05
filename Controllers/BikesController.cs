using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreKirjautuminen.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BikesController : ControllerBase
    {

        [Authorize]
        [HttpGet]
        [Route("")]
        public string[] GetBikes()
        { 
         string[] bikes = new string[] { "Nishiki", "Nakamura", "Crescent" };
         return bikes;
        }
    }
}
