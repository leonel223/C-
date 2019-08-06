﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using salvo1.Repositories;

namespace salvo1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        // GET: api/Players
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Players/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Players
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Players/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    
        readonly IPlayerRepository playerRepository;
        public PlayersController()
        {
            playerRepository = new IPlayerRepository();
        }
        // GET: api/Players
        [HttpGet]
        public IActionResult GetPlayer()
        {
            return Ok(playerRepository.ObterTodos());
        }
    }
}