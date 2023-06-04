using AutoMapper;
using BoschApp.BusinessLayer.Abstract;
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
    }
}
