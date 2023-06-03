using AutoMapper;
using BoschApp.BusinessLayer.Abstract;
using BoschApp.BusinessLayer.Dto;
using BoschApp.WebAPI.Dto;
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

        [HttpGet("{departmanId}")]
        public IActionResult GetDepartman(int departmanId)
        {
            try
            {
                var departman = _mapper.Map<DepartmanDto>(_departmanBusinessService.GetDepartman(departmanId));

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                return Ok(departman);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet()]
        public IActionResult GetDepartmans()
        {
            try
            {
                var departmans = _mapper.Map<List<DepartmanDto>>(_departmanBusinessService.GetDepartmans());

                if (!ModelState.IsValid) 
                { 
                    return BadRequest(ModelState);
                }

                return Ok(departmans);
            }
            catch( Exception ex )
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
