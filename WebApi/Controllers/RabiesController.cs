using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RabiesController : ControllerBase
    {
        IRabiesService _rabiesService;

        public RabiesController(IRabiesService rabiesService)
        {
            _rabiesService = rabiesService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _rabiesService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("id")]
        public IActionResult GetById(int id)
        {
            var result = _rabiesService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpPost]
        public IActionResult Add(Rabies rabies)
        {
            var result = _rabiesService.Add(rabies);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPut]
        public IActionResult Update(Rabies rabies)
        {
            var result = _rabiesService.Update(rabies);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpDelete]
        public IActionResult Delete(Rabies rabies)
        {
            var result = _rabiesService.Delete(rabies);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
