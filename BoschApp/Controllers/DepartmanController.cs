using AutoMapper;
using BoschApp.BusinessLayer.Abstract;
using BoschApp.BusinessLayer.Dto;
using Microsoft.AspNetCore.Mvc;

namespace BoschApp.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmanController : Controller
    {
        private readonly IDepartmanBusinessService _departmanBusinessService;
        private readonly IMapper _mapper;

        public DepartmanController(IDepartmanBusinessService departmanBusinessService, IMapper mapper)
        {
            _departmanBusinessService = departmanBusinessService;
            _mapper = mapper;
        }

        [HttpGet("{departmanId}/alan")]
        public IActionResult GetAlanByDepartman(int departmanId)
        {
            try
            {
                var alan = _mapper.Map<AlanDto>(_departmanBusinessService.GetAlanByDepartman(departmanId));

                if(!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                return Ok(alan);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
