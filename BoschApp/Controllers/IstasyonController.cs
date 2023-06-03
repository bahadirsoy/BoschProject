using AutoMapper;
using BoschApp.BusinessLayer.Abstract;
using BoschApp.EntityLayer.Entities.AltParcaEntity;
using BoschApp.WebAPI.Dto;
using Microsoft.AspNetCore.Mvc;

namespace BoschApp.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IstasyonController : Controller
    {
        private readonly IIstasyonBusinessService _istasyonBusinessService;
        private readonly IMapper _mapper;

        public IstasyonController(IIstasyonBusinessService istasyonBusinessService, IMapper mapper)
        {
            _istasyonBusinessService = istasyonBusinessService;
            _mapper = mapper;
        }

        [HttpGet("{istasyonId}/altParca")]
        public IActionResult GetAltParcasByIstasyon(int istasyonId)
        {
            try
            {
                var altParcas = _mapper.Map<List<AltParcaDto>>(_istasyonBusinessService.GetAltParcasByIstasyon(istasyonId));

                if(!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                return Ok(altParcas);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{istasyonId}")]
        public IActionResult GetIstasyon(int istasyonId)
        {
            try
            {
                var istasyon = _mapper.Map<IstasyonDto>(_istasyonBusinessService.GetIstasyon(istasyonId));

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                return Ok(istasyon);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
