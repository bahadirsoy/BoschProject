using AutoMapper;
using BoschApp.BusinessLayer.Abstract;
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
    }
}
