﻿using AutoMapper;
using BoschApp.BusinessLayer.Abstract;
using BoschApp.WebAPI.Dto;
using Microsoft.AspNetCore.Mvc;

namespace BoschApp.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KisimController : Controller
    {
        private readonly IKisimBusinessService _kisimBusinessService;
        private readonly IMapper _mapper;

        public KisimController(IKisimBusinessService kisimBusinessService, IMapper mapper)
        {
            _kisimBusinessService = kisimBusinessService;
            _mapper = mapper;
        }

        [HttpGet("{kisimId}/departman")]
        public IActionResult GetDepartmanByKisim(int kisimId)
        {
            try
            {
                var departman = _mapper.Map<DepartmanDto>(_kisimBusinessService.GetDepartmanByKisim(kisimId));

                if(!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                return Ok(departman);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{kisimId}/enjektor")]
        public IActionResult GetEnjektorsByKisim(int kisimId)
        {
            try
            {
                var enjektors = _mapper.Map<List<EnjektorDto>>(_kisimBusinessService.GetEnjektorsByKisim(kisimId));

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                return Ok(enjektors);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
