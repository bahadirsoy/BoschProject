using BoschApp.BusinessLayer.Abstract;
using BoschApp.BusinessLayer.Rules;
using BoschApp.DataAccessLayer.Abstract;
using BoschApp.EntityLayer.Entities.AltParcaEntity;
using BoschApp.EntityLayer.Entities.IstasyonEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschApp.BusinessLayer.Concrete
{
    public class IstasyonBusinessService : IIstasyonBusinessService
    {
        private readonly IIstasyonRepository _istasyonRepository;
        private readonly BusinessRules _rules;

        public IstasyonBusinessService(IIstasyonRepository istasyonRepository, BusinessRules rules)
        {
            _istasyonRepository = istasyonRepository;
            _rules = rules;
        }

        public ICollection<AltParca> GetAltParcasByIstasyon(int istasyonId)
        {
            throw new NotImplementedException();
        }

        public Istasyon GetIstasyon(int istasyonId)
        {
            throw new NotImplementedException();
        }

        public ICollection<Istasyon> GetIstasyons()
        {
            throw new NotImplementedException();
        }
    }
}
