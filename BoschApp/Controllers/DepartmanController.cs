using AutoMapper;
using BoschApp.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BoschApp.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmanController
    {
        private readonly IDepartmanBusinessService _departmanBusinessService;
        private readonly IMapper _mapper;

        public DepartmanController(IDepartmanBusinessService departmanBusinessService, IMapper mapper)
        {
            _departmanBusinessService = departmanBusinessService;
            _mapper = mapper;
        }
    }
}
