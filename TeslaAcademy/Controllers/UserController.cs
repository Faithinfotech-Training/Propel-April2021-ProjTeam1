using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TeslaAcademy.Models;

namespace TeslaAcademy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly TeslaContext _Context;

        public UserController(TeslaContext _context)
        {
            _Context = _context;
        }
        [HttpGet]
        //[EnableCors("CorsPolicy")]
        public ActionResult<List<User>> Get()
        {
            return Ok(_Context.User.ToList());
        }

        [HttpPost]
        //[EnableCors("CorsPolicy")]
        public ActionResult<List<User>> Post(User user)
        {
            _Context.User.Add(user);
            _Context.SaveChanges();
            return Ok(user);
        }
        [HttpPut]
        //[EnableCors("CorsPolicy")]
        public ActionResult<List<User>> Put(User user)
        {
            var dbUser = _Context.User.FirstOrDefault(em => em.Userid == user.Userid);
            dbUser.Username = user.Username;
            dbUser.Orgid = user.Orgid;
            dbUser.Rolename = user.Rolename;
            dbUser.Password = user.Password;
            dbUser.Email = user.Email;
            dbUser.Contact = user.Contact;
            dbUser.Userimage = user.Userimage;
            dbUser.Permissionid = user.Permissionid;
            dbUser.Setpermission = user.Setpermission;
            dbUser.Isactive = user.Isactive;
            dbUser.Createddate = user.Createddate;
            _Context.SaveChanges();
            return Ok(user);
        }


        //delete
        [HttpDelete]
        //[EnableCors("CorsPolicy")]
        public ActionResult<User> Delete(int id)
        {
            var dbUser = _Context.User.FirstOrDefault(em => em.Userid == id);
            _Context.Remove(dbUser);
            _Context.SaveChanges();
            return Ok(dbUser);
        }
    }
}

   