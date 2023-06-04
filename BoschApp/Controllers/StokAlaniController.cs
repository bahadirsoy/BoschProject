using AutoMapper;
using BoschApp.BusinessLayer.Abstract;
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
    }
}
