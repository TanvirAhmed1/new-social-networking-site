﻿using API.Data;
using API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public  ActionResult<IEnumerable<AppUser>> GetUsers()
        {
            return _context.Users.ToList();
        }
        [HttpGet("{id}")]
        public ActionResult<AppUser> GetUsers(int id)
        {
            return _context.Users.Find(id);
        }

    }
}