using BoschApp.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BoschApp.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlanController : Controller
    {
        private readonly IAlanBusinessService _alanBusinessService;

        public AlanController(IAlanBusinessService alanBusinessService)
        {
            _alanBusinessService = alanBusinessService;
        }

        [HttpGet]
        public IActionResult GetAlans()
        {
            var alans = _alanBusinessService.GetAlans();

            return Ok(alans);
        }
    }
}
