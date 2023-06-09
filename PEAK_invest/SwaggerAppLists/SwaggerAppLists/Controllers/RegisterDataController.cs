using Microsoft.AspNetCore.Mvc;
using SwaggerAppLists.Models;
using System.Collections.Generic;

namespace SwaggerAppLists.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterDataController : ControllerBase
    {
        private readonly Services.IDataService _dataService;

        public RegisterDataController(Services.IDataService dataService)
        {
            _dataService = dataService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var data = _dataService.GetAllData();
            return Ok(data);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var data = _dataService.GetDataById(id);
            if (data.Key == 0 && data.Value == null)
                return NotFound();

            return Ok(data);
        }


        [HttpPost]
        public IActionResult Post([FromBody] FormData formData)
        {
            try
            {
                double resultadoFinal = _dataService.CalculateFinalResult(formData);
                return Ok(resultadoFinal);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] string value)
        {
            // Implementar update
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            // Implementar delete
            return NoContent();
        }
    }
}
