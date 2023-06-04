using AutoMapper;
using BoschApp.BusinessLayer.Dto;
using BoschApp.EntityLayer.Entities.AlanEntity;
using BoschApp.EntityLayer.Entities.AltParcaEntity;
using BoschApp.EntityLayer.Entities.DepartmanEntityEntity;
using BoschApp.EntityLayer.Entities.EnjektorEntity;
using BoschApp.EntityLayer.Entities.IstasyonEntity;
using BoschApp.EntityLayer.Entities.KisimEntity;
using BoschApp.EntityLayer.Entities.SiparisEntity;
using BoschApp.EntityLayer.Entities.StokAlaniEntity;
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
            CreateMap<Enjektor, EnjektorDto>();
            CreateMap<Istasyon, IstasyonDto>();
            CreateMap<AltParca, AltParcaDto>();
            CreateMap<StokAlani, StokAlaniDto>();
            CreateMap<Siparis, SiparisDto>();
            CreateMap<SiparisDto, Siparis>();
        }
    }
}
