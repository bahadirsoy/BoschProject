using AutoMapper;
using BoschApp.BusinessLayer.Abstract;
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
    }
}
