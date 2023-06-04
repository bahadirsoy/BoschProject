using AutoMapper;
using BoschApp.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BoschApp.WebAPI.Controllers
{
    public class AltParcaController : Controller
    {
        private readonly IAltParcaBusinessService _altParcaBusinessService;
        private readonly IMapper _mapper;

        public AltParcaController(IAltParcaBusinessService altParcaBusinessService, IMapper mapper)
        {
            _altParcaBusinessService = altParcaBusinessService;
            _mapper = mapper;
        }
    }
}
