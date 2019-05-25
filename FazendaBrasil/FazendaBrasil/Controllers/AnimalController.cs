using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FazendaBrasil.Business.ApplicationService;
using FazendaBrasil.Business.ValueObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Tapioca.HATEOAS;

namespace FazendaBrasil.Controllers
{
    [Produces("application/json")]
    [Route("api/Animal")]
    public class AnimalController : Controller
    {
        private IAnimalApplicationService _service;

        public AnimalController(IAnimalApplicationService service)
        {
            _service = service;
        }

        [HttpGet]
        [SwaggerResponse((200), Type = typeof(List<AnimalVO>))]
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
        [SwaggerResponse((200), Type = typeof(List<AnimalVO>))]
        [SwaggerResponse(204)]
        [SwaggerResponse(400)]
        [SwaggerResponse(401)]
        [SwaggerResponse(404)]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Get(int id)
        {
            var AnimalVO = _service.Find(id);
            if (AnimalVO == null) return NotFound();

            return Ok(AnimalVO);
        }

        // POST api/Animal/values
        [HttpPost]
        [SwaggerResponse((201), Type = typeof(List<AnimalVO>))]
        [SwaggerResponse(400)]
        [SwaggerResponse(401)]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Post([FromBody]AnimalVO AnimalVO)
        {
            if (AnimalVO == null) return BadRequest();

            return new ObjectResult(_service.Add(AnimalVO));
        }

        [HttpPut("{id}")]
        [SwaggerResponse((202), Type = typeof(List<AnimalVO>))]
        [SwaggerResponse(400)]
        [SwaggerResponse(401)]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Put([FromBody]AnimalVO AnimalVO)
        {
            if (AnimalVO == null) return BadRequest();

            return new ObjectResult(_service.Update(AnimalVO));
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