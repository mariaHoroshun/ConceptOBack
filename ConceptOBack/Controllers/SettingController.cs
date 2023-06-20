using ConceptOBack.Interfaces;
using ConceptOBack.Models;
using ConceptOBack.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ConceptOBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SettingController : Controller
    {
        private readonly ISettingRepository _settingRepository;

        public SettingController(ISettingRepository settingRepository)
        {
            _settingRepository = settingRepository;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(ICollection<Setting>))]
        public IActionResult GetSettings()
        {
            var settings = _settingRepository.GetSettings();
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(settings);
        }
    }
}
