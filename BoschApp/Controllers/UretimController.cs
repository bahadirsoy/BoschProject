using AutoMapper;
using BoschApp.BusinessLayer.Abstract;
using BoschApp.EntityLayer.Entities.UretimEntity;
using BoschApp.WebAPI.Dto;
using Microsoft.AspNetCore.Mvc;

namespace BoschApp.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UretimController : Controller
    {
        private readonly IUretimBusinessService _uretimBusinessService;
        private readonly ISiparisBusinessService _siparisBusinessService;
        private readonly IAltParcaBusinessService _altParcaBusinessService;
        private readonly IMapper _mapper;

        public UretimController(
            IUretimBusinessService uretimBusinessService,
            ISiparisBusinessService siparisBusinessService,
            IAltParcaBusinessService altParcaBusinessService,
            IMapper mapper)
        {
            _uretimBusinessService = uretimBusinessService;
            _siparisBusinessService = siparisBusinessService;
            _altParcaBusinessService = altParcaBusinessService;
            _mapper = mapper;
        }

        [HttpGet("{uretimId}")]
        public IActionResult GetUretim(int uretimId)
        {
            try
            {
                var uretim = _mapper.Map<UretimDto>(_uretimBusinessService.GetUretim(uretimId));

                if(!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                return Ok(uretim);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
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

        [HttpGet("{uretimId}/siparis")]
        public IActionResult GetSiparisByUretim(int uretimId)
        {
            try
            {
                var siparis = _mapper.Map<SiparisDto>(_uretimBusinessService.GetSiparisByUretim(uretimId));

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                return Ok(siparis);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult CreateUretim(
            [FromQuery] int siparisId, 
            [FromQuery] int altParcaId, 
            [FromBody] UretimDto uretim)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var uretimMap = _mapper.Map<Uretim>(uretim);

            uretimMap.Siparis = _siparisBusinessService.GetSiparis(siparisId);
            uretimMap.AltParca = _altParcaBusinessService.GetAltParca(altParcaId);

            if (!_uretimBusinessService.CreateSiparis(uretimMap))
            {
                ModelState.AddModelError("", "Something went wrong while creating uretim");
                return StatusCode(500, ModelState);
            }

            return Ok("Succesfully added new uretim");
        }

        
    }
}
