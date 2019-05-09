using FazendaBrasil.Business.ApplicationService;
using FazendaBrasil.Business.ValueObjects;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Tapioca.HATEOAS;
using Swashbuckle.AspNetCore.Annotations;

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

        [HttpGet]
        [SwaggerResponse((200), Type = typeof(List<FrequencyVO>))]
        [SwaggerResponse(204)]
        [SwaggerResponse(400)]
        [SwaggerResponse(401)]
        [SwaggerResponse(404)]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Get()
        {
            return Ok(_service.GetAll());
        }

        [HttpGet("{id}")]
        [SwaggerResponse((200), Type = typeof(List<FrequencyVO>))]
        [SwaggerResponse(204)]
        [SwaggerResponse(400)]
        [SwaggerResponse(401)]
        [SwaggerResponse(404)]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Get(int id)
        {
            var frequencyVO = _service.Find(id);
            if (frequencyVO == null) return NotFound();

            return Ok(frequencyVO);
        }

        // POST api/Frequency/values
        [HttpPost]
        [SwaggerResponse((201), Type = typeof(List<FrequencyVO>))]
        [SwaggerResponse(400)]
        [SwaggerResponse(401)]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Post([FromBody]FrequencyVO frequencyVO)
        {
            if (frequencyVO == null) return BadRequest();

            return new ObjectResult(_service.Add(frequencyVO));
        }


        [HttpPut("{id}")]
        [SwaggerResponse((202), Type = typeof(List<FrequencyVO>))]
        [SwaggerResponse(400)]
        [SwaggerResponse(401)]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Put([FromBody]FrequencyVO frequencyVO)
        {
            if (frequencyVO == null) return BadRequest();

            return new ObjectResult(_service.Update(frequencyVO));
        }

        [HttpDelete("{id}")]
        [SwaggerResponse(204)]
        [SwaggerResponse(400)]
        [SwaggerResponse(401)]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Delete(int id)
        {
            _service.Remove(id);

            return NoContent();
        }
    }
}