using BoschApp.BusinessLayer.Abstract;
using BoschApp.BusinessLayer.Rules;
using BoschApp.DataAccessLayer.Abstract;
using BoschApp.EntityLayer.Entities.AlanEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschApp.BusinessLayer.Concrete
{
    public class AlanBusinessService : IAlanBusinessService
    {
        private readonly IAlanRepository _alanRepository;
        private readonly BusinessRules _rules;

        public AlanBusinessService(IAlanRepository alanRepository, BusinessRules rules)
        {
            _alanRepository = alanRepository;
            _rules = rules;
        }

        public Alan GetAlan(int alanId)
        {
            if (!_alanRepository.AlanExist(alanId))
            {
                throw new Exception("There is no Alan with id: " + alanId);
            }

            var alan = _alanRepository.GetAlan(alanId);

            return alan;
        }

        public ICollection<Alan> GetAlans()
        {
            var alans = _alanRepository.GetAlans();

            _rules.IsNull(alans);

            return alans;
        }
    }
}
