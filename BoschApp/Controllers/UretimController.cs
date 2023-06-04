using AutoMapper;
using BoschApp.BusinessLayer.Abstract;
using BoschApp.WebAPI.Dto;
using Microsoft.AspNetCore.Mvc;

namespace BoschApp.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UretimController : Controller
    {
        private readonly IUretimBusinessService _uretimBusinessService;
        private readonly IMapper _mapper;

        public UretimController(IUretimBusinessService uretimBusinessService, IMapper mapper)
        {
            _uretimBusinessService = uretimBusinessService;
            _mapper = mapper;
        }

        [HttpGet("{uretimId}/altparca")]
        public IActionResult GetAltParcaByUretim(int uretimId)
        {
            try
            {
                var altParca = _mapper.Map<AltParcaDto>(_uretimBusinessService.GetAltParcaByUretim(uretimId));

                if(!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                return Ok(altParca);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
