using AutoMapper;
using BoschApp.BusinessLayer.Abstract;
using BoschApp.WebAPI.Dto;
using Microsoft.AspNetCore.Mvc;

namespace BoschApp.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnjektorController : Controller
    {
        private readonly IEnjektorBusinessService _enjektorBusinessService;
        private readonly IMapper _mapper;

        public EnjektorController(IEnjektorBusinessService enjektorBusinessService, IMapper mapper)
        {
            _enjektorBusinessService = enjektorBusinessService;
            _mapper = mapper;
        }

        [HttpGet("{enjektorId}/altParca")]
        public IActionResult GetAltParcasByEnjektor(int enjektorId)
        {
            try
            {
                var altParcas = _mapper.Map<List<AltParcaDto>>(_enjektorBusinessService.GetAltParcasByEnjektor(enjektorId));

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

        [HttpGet("{enjektorId}")]
        public IActionResult GetEnjektor(int enjektorId)
        {
            try
            {
                var enjektor = _mapper.Map<EnjektorDto>(_enjektorBusinessService.GetEnjektor(enjektorId));

                if(!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                return Ok(enjektor);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet()]
        public IActionResult GetEnjektors()
        {
            try
            {
                var enjektors = _mapper.Map<List<EnjektorDto>>(_enjektorBusinessService.GetEnjektors());

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                return Ok(enjektors);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
