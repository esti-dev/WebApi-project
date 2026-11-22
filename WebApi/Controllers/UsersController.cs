using Microsoft.AspNetCore.Mvc;
//This using isn't used in this file: you can remove it
using System.Text.Json;
using Entities;
using Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]


    public class UsersController : ControllerBase
    {
        //The assignment asks the users controller to take IPasswordService and call it to check the password: where would you add it, and what would you pass to it?
        IUserService userServices;
        public UsersController(IUserService userService)
        {
            this.userServices = userService;
        }

        // GET: api/<UsersController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return userServices.Get();
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public ActionResult<User> Get(int id)
        {
            if(userServices.Get(id) != null)
                        return userServices.Get(id);
                
            return NoContent();
            
        }
        
        // POST api/<UsersController>
        [HttpPost]
        //The assignment asks POST to return 400 for a weak password (score below 3): where would you check the score before saving?
        public ActionResult<User> Post([FromBody] User user)
        {
            user = userServices.Post(user);
            return CreatedAtAction(nameof(Get),new {Id = user.Id },user);
        }


        [HttpPost("login")]
        public ActionResult<User> Login([FromBody] LoginUser loginUser)
        {

            if (userServices.Login(loginUser) != null)
                return Ok(userServices.Login(loginUser));
            
            return NoContent();
        }



        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        //The assignment asks PUT to return 400 for a weak password (score below 3): where would you check the score before updating?
        public IActionResult Put(int id,[FromBody] User userPut)
        {
           userServices.Put(id,userPut);
            return Ok();
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
