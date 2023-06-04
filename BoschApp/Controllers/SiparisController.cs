using AutoMapper;
using BoschApp.BusinessLayer.Abstract;
using BoschApp.WebAPI.Dto;
using Microsoft.AspNetCore.Mvc;

namespace BoschApp.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SiparisController : Controller
    {
        private readonly ISiparisBusinessService _siparisBusinessService;
        private readonly IMapper _mapper;

        public SiparisController(ISiparisBusinessService siparisBusinessService, IMapper mapper)
        {
            _siparisBusinessService = siparisBusinessService;
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
    }
}
