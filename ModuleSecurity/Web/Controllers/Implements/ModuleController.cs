﻿using Bussines.Interfaces;
using Entity.DTO;
using Entity.Model.Security;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers.Implements
{
    [ApiController]
    [Route("[controller]")]
    public class ModuloController : ControllerBase
    {
        private readonly IModuleBusiness _moduleBusiness;

        public ModuloController(IModuleBusiness moduleBusiness)
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

        [HttpPost]
        public async Task<ActionResult<Module>> Save([FromBody] ModuleDto moduleDto)
        {
            if (moduleDto == null)
            {
                return BadRequest("La entidad es nula");
            }

            var result = await _moduleBusiness.Save(moduleDto);
            return CreatedAtAction(nameof(GetById), new { id = result.Id }, result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromBody] ModuleDto moduleDto)
        {
            if (moduleDto == null || moduleDto.Id == 0)
            {
                return BadRequest();
            }

            await _moduleBusiness.Update(moduleDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _moduleBusiness.Delete(id);
            return NoContent();
        }
    }
}