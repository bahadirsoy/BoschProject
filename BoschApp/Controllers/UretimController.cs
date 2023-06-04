using AutoMapper;
using BoschApp.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BoschApp.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UretimController : Controller
    {
        private readonly IUretimBusinessService _uretimBusinessService;
        private readonly IMapper _mapper;

        public UretimController(IUretimBusinessService uretimBusinessService, IMapper mapper)
        {
            _uretimBusinessService = uretimBusinessService;
            _mapper = mapper;
        }
    }
}
