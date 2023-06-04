using BoschApp.BusinessLayer.Abstract;
using BoschApp.BusinessLayer.Rules;
using BoschApp.DataAccessLayer.Abstract;
using BoschApp.EntityLayer.Entities.EnjektorEntity;
using BoschApp.EntityLayer.Entities.SiparisEntity;
using BoschApp.EntityLayer.Entities.UretimEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschApp.BusinessLayer.Concrete
{
    public class SiparisBusinessService : ISiparisBusinessService
    {
        private readonly ISiparisRepository _siparisRepository;
        private readonly BusinessRules _rules;

        public SiparisBusinessService(ISiparisRepository siparisRepository, BusinessRules rules)
        {
            _siparisRepository = siparisRepository;
            _rules = rules;
        }

        public Enjektor GetEnjektorBySiparis(int siparisId)
        {
            throw new NotImplementedException();
        }

        public Siparis GetSiparis(int siparisId)
        {
            throw new NotImplementedException();
        }

        public ICollection<Siparis> GetSiparises()
        {
            throw new NotImplementedException();
        }

        public ICollection<Uretim> GetUretimsBySiparis(int siparisId)
        {
            throw new NotImplementedException();
        }
    }
}
