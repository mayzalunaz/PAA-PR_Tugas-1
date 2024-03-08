﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PercobaanApi1.Models;
namespace PercobaanApi1.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost("api/person")]
        public ActionResult<Person> ListPerson()
        {
            PersonContext context = new PersonContext();
            List<Person> ListPerson = context.ListPerson();
            return Ok(ListPerson);
        }

        [HttpGet("api/person/id")]
        public ActionResult <Person> GetPersonById(int id) 
        {
            PersonContext context = new PersonContext();
            var person = context.GetPersonById(id);
            if (person != null) 
            {
                return Ok(person);
            }
            else
            {
                return NotFound();
            }
        }

    }
}
