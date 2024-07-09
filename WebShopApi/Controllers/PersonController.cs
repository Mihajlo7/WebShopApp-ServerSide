using Microsoft.AspNetCore.Mvc;
using Persons.Service;

namespace WebShopApi.Controllers
{
    [ApiController]
    [Route("/api/v1/[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;  
        }

        [HttpGet("/getCountries")]
        public async Task<IActionResult> GetAllCountries()
        {
            return Ok(await _personService.GetAllCountries());
        }
    }
}
