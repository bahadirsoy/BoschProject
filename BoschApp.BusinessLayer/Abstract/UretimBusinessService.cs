using BoschApp.BusinessLayer.Rules;
using BoschApp.DataAccessLayer.Abstract;
using BoschApp.EntityLayer.Entities.AltParcaEntity;
using BoschApp.EntityLayer.Entities.SiparisEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschApp.BusinessLayer.Abstract
{
    public class UretimBusinessService : IUretimBusinessService
    {
        private readonly IUretimRepository _uretimRepository;
        private readonly BusinessRules _rules;

        public UretimBusinessService(IUretimRepository uretimRepository, BusinessRules rules)
        {
            _uretimRepository = uretimRepository;
            _rules = rules;
        }

        public AltParca GetAltParcaByUretim(int uretimId)
        {
            throw new NotImplementedException();
        }

        public Siparis GetSiparisByUretim(int uretimId)
        {
            throw new NotImplementedException();
        }
    }
}
