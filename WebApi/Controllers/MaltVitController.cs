using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaltVitController : ControllerBase
    {
        IMaltVitService _maltVitService;

        public MaltVitController(IMaltVitService maltVitService)
        {
            _maltVitService = maltVitService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _maltVitService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("id")]
        public IActionResult GetById(int id)
        {
            var result = _maltVitService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpPost]
        public IActionResult Add(MaltVit maltVit)
        {
            var result = _maltVitService.Add(maltVit);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPut]
        public IActionResult Update(MaltVit maltVit)
        {
            var result = _maltVitService.Update(maltVit);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpDelete]
        public IActionResult Delete(MaltVit maltVit)
        {
            var result = _maltVitService.Delete(maltVit);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
