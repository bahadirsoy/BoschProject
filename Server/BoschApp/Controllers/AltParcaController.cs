﻿using AutoMapper;
using BoschApp.BusinessLayer.Abstract;
using BoschApp.EntityLayer.Entities.AltParcaEntity;
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

        [HttpGet()]
        public IActionResult GetAltParcas()
        {
            try
            {
                var altParcas = _altParcaBusinessService.GetAltParcas();

                if (!ModelState.IsValid)
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

        [HttpGet("{altParcaId}/Istasyon")]
        public IActionResult GetIstasyonByAltParca(int altParcaId)
        {
            try
            {
                var istasyon = _mapper.Map<IstasyonDto>(_altParcaBusinessService.GetIstasyonByAltParca(altParcaId));

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

        [HttpGet("{altParcaId}/stokAlani")]
        public IActionResult GetStokAlaniByAltParca(int altParcaId)
        {
            try
            {
                var stokAlani = _altParcaBusinessService.GetStokAlaniByAltParca(altParcaId);

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                return Ok(stokAlani);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{altParcaId}")]
        public IActionResult UpdateAltParca(AltParcaDto altParca, int altParcaId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var altParcaMap = _mapper.Map<AltParca>(altParca);

            if(!_altParcaBusinessService.UpdateAltParca(altParcaMap, altParcaId))
            {
                ModelState.AddModelError("", "Something went wrong updating stokAlani");
                return StatusCode(500, ModelState);
            }

            return Ok("Succesfully updated altParca");
        }
    }
}
