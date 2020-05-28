using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace hw_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {

        [HttpGet("")]
        public ActionResult<string> Demo()
        {
            return "Test";
        }

        [HttpGet("Test/{id}")]
        public ActionResult<string> Demo2(int id)
        {
            return $"{id} Test2";
        }

        [HttpGet("Demo3")]
        public ActionResult<string> Demo3()
        {
            return "Demo3";
        }
    }
}