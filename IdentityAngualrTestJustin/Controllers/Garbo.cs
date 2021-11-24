using IdentityAngualrTestJustin.Data;
using IdentityAngualrTestJustin.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityAngualrTestJustin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Garbo : ControllerBase
    {
        public ApplicationDbContext context;

        public Garbo(ApplicationDbContext _context)
        {
            context = _context;
        }

        //[HttpGet()]
        //public ApplicationUser GetAllGarbos()
        //{
        //    return context.Garbo.Include(G => G.ApplicationUser).ToList()[0].ApplicationUser;
        //}

        [HttpGet()]
        public List<Garbage> GetAllGarbos()
        {
            return context.Garbo.ToList();
        }

        //[HttpGet("Get")]
        //absolutely nothing


    }
}
