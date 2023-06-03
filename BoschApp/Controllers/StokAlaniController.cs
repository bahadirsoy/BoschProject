using AutoMapper;
using BoschApp.BusinessLayer.Abstract;
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
    }
}
