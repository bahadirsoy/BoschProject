using AutoMapper;
using BoschApp.BusinessLayer.Dto;
using BoschApp.EntityLayer.Entities.AlanEntity;

namespace BoschApp.WebAPI.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Alan, AlanDto>();
        }
    }
}
