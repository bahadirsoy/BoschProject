using AutoMapper;
using BoschApp.BusinessLayer.Abstract;
using BoschApp.EntityLayer.Entities.StokAlaniEntity;
using BoschApp.WebAPI.Dto;
using Microsoft.AspNetCore.Mvc;

namespace BoschApp.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StokAlaniController : Controller
    {
        private readonly IStokAlaniBusinessService _stokAlaniBusinessService;
        private readonly IMapper _mapper;

        public StokAlaniController(IStokAlaniBusinessService stokAlaniBusinessService, IMapper mapper)
        {
            _stokAlaniBusinessService = stokAlaniBusinessService;
            _mapper = mapper;
        }

        [HttpGet()]
        public IActionResult GetStokAlanis()
        {
            try
            {
                var stokAlanis = _mapper.Map<List<StokAlaniDto>>(_stokAlaniBusinessService.GetStokAlanis());

                if(!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                return Ok(stokAlanis);
            }
            catch (Exception ex) 
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{stokAlaniId}")]
        public IActionResult GetStokAlani(int stokAlaniId)
        {
            try
            {
                var stokAlani = _mapper.Map<StokAlaniDto>(_stokAlaniBusinessService.GetStokAlani(stokAlaniId));

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                return Ok(stokAlani);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{stokAlaniId}")]
        public IActionResult UpdateStokAlani(StokAlaniDto stokAlani, int stokAlaniId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var stokAlaniMap = _mapper.Map<StokAlani>(stokAlani);

            if(!_stokAlaniBusinessService.UpdateStokAlani(stokAlaniMap, stokAlaniId))
            {
                ModelState.AddModelError("", "Something went wrong updating stokAlani");
                return StatusCode(500, ModelState);
            }

            return Ok("Succesfully updated stokAlani");
        }
    }
}
