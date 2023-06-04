using BoschApp.BusinessLayer.Abstract;
using BoschApp.BusinessLayer.Rules;
using BoschApp.DataAccessLayer.Abstract;
using BoschApp.EntityLayer.Entities.AltParcaEntity;
using BoschApp.EntityLayer.Entities.EnjektorEntity;
using BoschApp.EntityLayer.Entities.KisimEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschApp.BusinessLayer.Concrete
{
    public class EnjektorBusinessService : IEnjektorBusinessService
    {
        private readonly IEnjektorRepository _enjektorRepository;
        private readonly BusinessRules _rules;

        public EnjektorBusinessService(IEnjektorRepository enjektorRepository, BusinessRules rules)
        {
            _enjektorRepository = enjektorRepository;
            _rules = rules;
        }

        public ICollection<AltParca> GetAltParcasByEnjektor(int enjektorId)
        {
            throw new NotImplementedException();
        }

        public Enjektor GetEnjektor(int enjektorId)
        {
            throw new NotImplementedException();
        }

        public ICollection<Enjektor> GetEnjektors()
        {
            throw new NotImplementedException();
        }

        public Kisim GetKisimByEnjektor(int enjektorId)
        {
            throw new NotImplementedException();
        }
    }
}
