using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeukemiaController : ControllerBase
    {
        ILeukemiaService _leukemiaService;

        public LeukemiaController(ILeukemiaService leukemiaService)
        {
            _leukemiaService = leukemiaService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _leukemiaService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("id")]
        public IActionResult GetById(int id)
        {
            var result = _leukemiaService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpPost]
        public IActionResult Add(Leukemia leukemia)
        {
            var result = _leukemiaService.Add(leukemia);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPut]
        public IActionResult Update(Leukemia leukemia)
        {
            var result = _leukemiaService.Update(leukemia);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpDelete]
        public IActionResult Delete(Leukemia leukemia)
        {
            var result = _leukemiaService.Delete(leukemia);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
