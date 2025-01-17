﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using leaveManAPI.Data;
using leaveManAPI.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace leaveManAPI.Controllers
{
    [Route("api/[controller]")]
    public class EmpLeaveMappingController : ControllerBase
    {
        // GET: /<controller>/
        //public IActionResult Index()
        //{
        //    return View();
        //}

        private readonly DataContext _db;


        public EmpLeaveMappingController(DataContext db)
        {
            _db = db;
        }
        // GET: /<controller>/
        //public IActionResult Index()
        //{
        //    return View();
        //}

        [HttpGet]
        public ActionResult<IEnumerable<EmpLeaveMapping>> Get()
        {
            var Empleavemap = _db.EmpLeaveMappings.ToList();
            return Ok(Empleavemap);
        }

        [HttpGet("{id}")]
        public ActionResult<EmpLeaveMapping> Get(int id)
        {
            var map = _db.EmpLeaveMappings.FirstOrDefault(a => a.Id == id);
            return Ok(map);
        }

        // [HttpPost]
        // public void Post([FromBody] string value)
        // {

        // }
        // [HttpPost]
        // public async Task<ActionResult<EmpLeaveMapping>> Post(EmpLeaveMapping empl){
        //     _db.EmpLeaveMappings.Add(empl);
        //     await _db.SaveChangesAsync();
        //     return CreatedAtAction(nameof())
        // }
        [HttpPost]
        public ActionResult<EmpLeaveMapping> Post([FromBody] EmpLeaveMapping empleave)
        {
            _db.EmpLeaveMappings.Add(empleave);
             _db.SaveChanges();
            return Ok(empleave);
            
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }




    }
}
