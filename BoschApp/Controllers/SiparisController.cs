using AutoMapper;
using BoschApp.BusinessLayer.Abstract;
using BoschApp.EntityLayer.Entities.SiparisEntity;
using BoschApp.WebAPI.Dto;
using Microsoft.AspNetCore.Mvc;

namespace BoschApp.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SiparisController : Controller
    {
        private readonly ISiparisBusinessService _siparisBusinessService;
        private readonly IEnjektorBusinessService _enjektorBusinessService;
        private readonly IMapper _mapper;

        public SiparisController(
            ISiparisBusinessService siparisBusinessService,
            IEnjektorBusinessService enjektorBusinessService,
            IMapper mapper)
        {
            _siparisBusinessService = siparisBusinessService;
            _enjektorBusinessService = enjektorBusinessService;
            _mapper = mapper;
        }

        [HttpGet("{siparisId}/enjektor")]
        public IActionResult GetEnjektorBySiparis(int siparisId)
        {
            try
            {
                var enjektor = _mapper.Map<EnjektorDto>(_siparisBusinessService.GetEnjektorBySiparis(siparisId));

                if(!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                return Ok(enjektor);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{siparisId}")]
        public IActionResult GetSiparis(int siparisId)
        {
            try
            {
                var siparis = _mapper.Map<SiparisDto>(_siparisBusinessService.GetSiparis(siparisId));

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

        [HttpGet()]
        public IActionResult GetSiparises()
        {
            try
            {
                var siparises = _mapper.Map<List<SiparisDto>>(_siparisBusinessService.GetSiparises());

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                return Ok(siparises);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{siparisId}/uretim")]
        public IActionResult GetUretimsBySiparis(int siparisId)
        {
            try
            {
                var uretims = _siparisBusinessService.GetUretimsBySiparis(siparisId);

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                return Ok(uretims);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult CreateSiparis([FromQuery] int enjektorId, [FromBody] SiparisDto siparis)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var siparisMap = _mapper.Map<Siparis>(siparis);

                siparisMap.Enjektor = _enjektorBusinessService.GetEnjektor(enjektorId);

                if (!_siparisBusinessService.CreateSiparis(siparisMap))
                {
                    ModelState.AddModelError("", "Something went wrong while creating siparis");
                    return StatusCode(500, ModelState);
                }

                return Ok("Succesfully added new siparis");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
