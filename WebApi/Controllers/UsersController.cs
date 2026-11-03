using Microsoft.AspNetCore.Mvc;
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
        UserServices userServices = new UserServices();

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
