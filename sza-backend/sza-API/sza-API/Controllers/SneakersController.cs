using Microsoft.AspNetCore.Mvc;
using Services.Handlers;
using sza_API.Models;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace sza_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SneakersController : ControllerBase
    {
        private IHandler<Sneaker, Sneaker> _sneakerHandler;

        public SneakersController(IHandler<Sneaker, Sneaker> sneakerHandler)
        {
            _sneakerHandler = sneakerHandler;
        }



        // GET: api/<SneakersController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<SneakersController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //POST api/<SneakersController>
        [HttpPost]
        public async Task<ActionResult> AddSneaker(Sneaker sneaker)
        {
            var result = await _sneakerHandler.Handle(sneaker);
            return Ok(result);
        }

        // PUT api/<SneakersController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<SneakersController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
