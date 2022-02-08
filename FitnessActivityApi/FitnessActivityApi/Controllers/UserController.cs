using FitnessActivityApi.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitnessActivityApi.Model;


namespace FitnessActivityApi.Controllers
{
    public class UserController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public UserController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpGet("api/GetUserDetails")]
        public IActionResult GetUserDetails()
        {
            var result = _appDbContext.userDetails.AsQueryable();

            return Ok(result);

        }

        [HttpPost("api/AddUserInformation")]
        public IActionResult AddUserInformation([FromBody]UserDetails model)
        {
            if (model == null)
            {
                return BadRequest();
            }

            else
            {
                _appDbContext.userDetails.Add(model);
                _appDbContext.SaveChanges();

                return Ok(new
                {
                    Status = 200,
                    Message = "User Registered Succefully"
                });
            }


        }

    }
}
