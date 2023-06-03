using AutoMapper;
using BoschApp.BusinessLayer.Abstract;
using BoschApp.BusinessLayer.Dto;
using Microsoft.AspNetCore.Mvc;

namespace BoschApp.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlanController : Controller
    {
        private readonly IAlanBusinessService _alanBusinessService;
        private readonly IMapper _mapper;

        public AlanController(IAlanBusinessService alanBusinessService, IMapper mapper)
        {
            _alanBusinessService = alanBusinessService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAlans()
        {
            try
            {
                var alans = _mapper.Map<List<AlanDto>>(_alanBusinessService.GetAlans());

                if(!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                return Ok(alans);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
