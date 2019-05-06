using FazendaBrasil.Business.ApplicationService;
using FazendaBrasil.Business.ValueObjects;
using Microsoft.AspNetCore.Mvc;

namespace FazendaBrasil.Controllers
{
    [Produces("application/json")]
    [Route("api/Frequency")]
    public class FrequencyController : Controller
    {
        private IFrequencyApplicationService _service;

        public FrequencyController(IFrequencyApplicationService service)
        {
            _service = service;
        }

        // GET api/Frequency/values
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.GetAll());
        }

        // GET api/Frequency/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var frequencyVO = _service.Find(id);
            if (frequencyVO == null) return NotFound();

            return Ok(frequencyVO);
        }

        // POST api/Frequency/values
        [HttpPost]
        public IActionResult Post([FromBody]FrequencyVO frequencyVO)
        {
            if (frequencyVO == null) return BadRequest();

            return new ObjectResult(_service.Add(frequencyVO));
        }

        // PUT api/Frequency/values/5
        [HttpPut("{id}")]
        public IActionResult Put([FromBody]FrequencyVO frequencyVO)
        {
            if (frequencyVO == null) return BadRequest();

            return new ObjectResult(_service.Update(frequencyVO));
        }

        // DELETE api/Frequency/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _service.Remove(id);

            return NoContent();
        }
    }
}