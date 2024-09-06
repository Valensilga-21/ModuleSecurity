using Entity.DTO;
using Entity.Model.Security;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers.Interfaces
{
    public interface ICountrieController
    {
        Task<IActionResult> Delete(int id);
        Task<ActionResult<CountriesDto>> GetById(int id);
        Task<ActionResult<Countrie>> Save([FromBody] CountriesDto countriesDto);
        Task<IActionResult> Update([FromBody] CountriesDto countriesDto);
        Task<ActionResult<IEnumerable<CountriesDto>>> GetAll();
    }
}
