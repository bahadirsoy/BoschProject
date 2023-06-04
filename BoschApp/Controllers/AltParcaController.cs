using AutoMapper;
using BoschApp.BusinessLayer.Abstract;
using BoschApp.WebAPI.Dto;
using Microsoft.AspNetCore.Mvc;

namespace BoschApp.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AltParcaController : Controller
    {
        private readonly IAltParcaBusinessService _altParcaBusinessService;
        private readonly IMapper _mapper;

        public AltParcaController(IAltParcaBusinessService altParcaBusinessService, IMapper mapper)
        {
            _altParcaBusinessService = altParcaBusinessService;
            _mapper = mapper;
        }

        [HttpGet("{altParcaId}")]
        public IActionResult GetAltParca(int altParcaId)
        {
            try
            {
                var altParca = _mapper.Map<AltParcaDto>(_altParcaBusinessService.GetAltParca(altParcaId));

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
