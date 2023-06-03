using AutoMapper;
using BoschApp.BusinessLayer.Dto;
using BoschApp.EntityLayer.Entities.AlanEntity;
using BoschApp.EntityLayer.Entities.DepartmanEntityEntity;
using BoschApp.EntityLayer.Entities.KisimEntity;
using BoschApp.WebAPI.Dto;

namespace BoschApp.WebAPI.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Alan, AlanDto>();
            CreateMap<Departman, DepartmanDto>();
            CreateMap<Kisim, KisimDto>();
        }
    }
}
