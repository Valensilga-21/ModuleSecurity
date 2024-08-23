using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers.Implement
{
    [ApiController]
    [Route("controller")]
    public class ModuleController : ControllerBase
    {
        private readonly IModuleBusiness _moduleBusiness;

        public ModuleController(IModuleBusiness moduleBusiness)
        {
            _moduleBusiness = moduleBusiness;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ModuleDto>>> GetAll()
        {
            var result = await _moduleBusiness.GetAll();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ModuleDto>> GetById(int id)
        {
            var result = await _moduleBusiness.GetById(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
    }
}
