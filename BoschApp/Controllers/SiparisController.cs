using AutoMapper;
using BoschApp.BusinessLayer.Abstract;
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
    }
}
