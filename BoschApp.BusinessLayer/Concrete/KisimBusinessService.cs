using BoschApp.BusinessLayer.Abstract;
using BoschApp.BusinessLayer.Rules;
using BoschApp.DataAccessLayer.Abstract;
using BoschApp.EntityLayer.Entities.DepartmanEntityEntity;
using BoschApp.EntityLayer.Entities.EnjektorEntity;
using BoschApp.EntityLayer.Entities.KisimEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschApp.BusinessLayer.Concrete
{
    public class KisimBusinessService : IKisimBusinessService
    {
        private readonly IKisimRepository _kisimRepository;
        private readonly BusinessRules _rules;

        public KisimBusinessService(IKisimRepository kisimRepository, BusinessRules rules)
        {
            _kisimRepository = kisimRepository;
            _rules = rules;
        }

        public Departman GetDepartmanByKisim(int kisimId)
        {
            throw new NotImplementedException();
        }

        public ICollection<Enjektor> GetEnjektorsByKisim(int kisimId)
        {
            throw new NotImplementedException();
        }

        public Kisim GetKisim(int kisimId)
        {
            throw new NotImplementedException();
        }

        public ICollection<Kisim> GetKisims()
        {
            throw new NotImplementedException();
        }
    }
}
