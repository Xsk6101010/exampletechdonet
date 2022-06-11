﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CustomersApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Customer 1", "Customer 2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return $"Customer {id}";
        }
    }
}