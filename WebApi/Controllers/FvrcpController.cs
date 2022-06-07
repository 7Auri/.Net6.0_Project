using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FvrcpController : ControllerBase
    {
        IFvrcpService _fvrcpService;

        public FvrcpController(IFvrcpService fvrcpService)
        {
            _fvrcpService = fvrcpService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _fvrcpService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("id")]
        public IActionResult GetById(int id)
        {
            var result = _fvrcpService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpPost]
        public IActionResult Add(Fvrcp fvrcp)
        {
            var result = _fvrcpService.Add(fvrcp);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPut]
        public IActionResult Update(Fvrcp fvrcp)
        {
            var result = _fvrcpService.Update(fvrcp);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpDelete]
        public IActionResult Delete(Fvrcp fvrcp)
        {
            var result = _fvrcpService.Delete(fvrcp);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
