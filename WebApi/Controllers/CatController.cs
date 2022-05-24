using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatController : ControllerBase
    {
        ICatService _catService;

        public CatController(ICatService catService)
        {
            _catService = catService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _catService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("id")]
        public IActionResult GetById(int id)
        {
            var result = _catService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpPost]
        public IActionResult Add(Cat cat)
        {
            var result = _catService.Add(cat);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPut]
        public IActionResult Update(Cat cat)
        {
            var result = _catService.Update(cat);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpDelete]
        public IActionResult Delete(Cat cat)
        {
            var result = _catService.Delete(cat);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}