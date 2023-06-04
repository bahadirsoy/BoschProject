using BoschApp.BusinessLayer.Abstract;
using BoschApp.BusinessLayer.Rules;
using BoschApp.DataAccessLayer.Abstract;
using BoschApp.EntityLayer.Entities.DepartmanEntityEntity;
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
            if(!_siparisRepository.SiparisExist(siparisId))
            {
                throw new Exception("There is no siparis with id: " + siparisId);
            }

            var enjektor = _siparisRepository.GetEnjektorBySiparis(siparisId);

            if(_rules.IsNull(enjektor))
            {
                throw new Exception("There is no enjektor belonging to this siparis");
            }

            return enjektor;
        }

        public Siparis GetSiparis(int siparisId)
        {
            if (!_siparisRepository.SiparisExist(siparisId))
            {
                throw new Exception("There is no siparis with id: " + siparisId);
            }

            var siparis = _siparisRepository.GetSiparis(siparisId);

            if(_rules.IsNull(siparis))
            {
                throw new Exception("There is no siparis");
            }

            return siparis;
        }

        public ICollection<Siparis> GetSiparises()
        {
            var siparises = _siparisRepository.GetSiparises();

            if (_rules.IsNull(siparises))
            {
                throw new Exception("There is no siparis");
            }

            return siparises;
        }

        public ICollection<Uretim> GetUretimsBySiparis(int siparisId)
        {
            if (!_siparisRepository.SiparisExist(siparisId))
            {
                throw new Exception("There is uretim belonging to this siparis");
            }

            var uretims = _siparisRepository.GetUretimsBySiparis(siparisId);

            if(_rules.IsNull(uretims)) 
            {
                throw new Exception("This siparis has no uretim");
            }

            return uretims;
        }
    }
}
