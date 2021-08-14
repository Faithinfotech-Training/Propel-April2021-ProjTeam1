using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeslaAcademy.Models;

namespace TeslaAcademy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly TeslaContext _Context;
        Degreelist degreelist = new Degreelist();

        //create parametrized constructor for getting db:TeslaContext
        public CourseController(TeslaContext _context)
        {
            _Context = _context;
        }

        //Endpoint Get Post Put Delete
        [HttpGet]
        //[EnableCors("CorsPolicy")]
        public ActionResult<List<Coursemain>> Get()
        {
            return Ok(_Context.Coursemain.ToList());
        }

        //Endpoint Get Post Put Delete

        //insert
        [HttpPost]
        //[EnableCors("CorsPolicy")]
        public ActionResult<Coursemain> Post(Coursemain coursemain)
        {
            _Context.Coursemain.Add(coursemain);
            _Context.SaveChanges();
            return Ok(coursemain);
        }

        //update put
        [HttpPut]
        //[EnableCors("CorsPolicy")]
        public ActionResult<Coursemain> Put(Coursemain coursemain)

        {
            var courseInDb = _Context.Coursemain.FirstOrDefault(em => em.Courseid == coursemain.Courseid);
            courseInDb.Orgid = coursemain.Orgid;
            courseInDb.Coursename = coursemain.Coursename;
            courseInDb.Courseduration = coursemain.Courseduration;
            courseInDb.Qualification = coursemain.Qualification;
            courseInDb.Timeslot = coursemain.Timeslot;
            courseInDb.Startdate = coursemain.Startdate;
            courseInDb.Closingdate = coursemain.Closingdate;
            courseInDb.Enddate = coursemain.Enddate;
            courseInDb.Backlog = coursemain.Backlog;
            courseInDb.Percentage = coursemain.Percentage;
            courseInDb.Experience = coursemain.Experience;
            courseInDb.Maxnoofcandidate =coursemain.Maxnoofcandidate;
            courseInDb.Description = coursemain.Description;
            courseInDb.Status = coursemain.Status;
            courseInDb.Isactive = coursemain.Isactive;
            courseInDb.Createddate = coursemain.Createddate;
            _Context.SaveChanges();
            return Ok(coursemain);
        }

        //delete https://localhost:44351/api/Employee?id=5
        [HttpDelete]
        //[EnableCors("CorsPolicy")]
        public ActionResult<Coursemain> Delete(int id)
        {
            var courseInDb = _Context.Coursemain.FirstOrDefault(em => em.Courseid == id);
            _Context.Remove(courseInDb);
            _Context.SaveChanges();
            return Ok(courseInDb);
        }

        //search by Id
        [HttpGet("GetEmployee")]
        //[EnableCors("CorsPolicy")]
        public ActionResult<Coursemain> Get(int id)
        {
            var courseInDb = _Context.Coursemain.FirstOrDefault(em => em.Courseid == id);//linq query
            return Ok(courseInDb);
        }


    }
}
