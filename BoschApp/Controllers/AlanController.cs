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
            var alans = _mapper.Map<List<AlanDto>>(_alanBusinessService.GetAlans());

            return Ok(alans);
        }
    }
}
