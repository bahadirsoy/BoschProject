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
            if (!_kisimRepository.KisimExist(kisimId))
            {
                throw new Exception("There is no kisim with id: " + kisimId);
            }

            var kisim = _kisimRepository.GetDepartmanByKisim(kisimId);

            if (_rules.IsNull(kisim))
            {
                throw new Exception("There is no departman belonging to this kisim");
            }

            return kisim;
        }

        public ICollection<Enjektor> GetEnjektorsByKisim(int kisimId)
        {
            if (!_kisimRepository.KisimExist(kisimId))
            {
                throw new Exception("There is no kisim with id: " + kisimId);
            }

            var enjektors = _kisimRepository.GetEnjektorsByKisim(kisimId);

            if (_rules.IsNull(enjektors))
            {
                throw new Exception("This kisim has no enjektor");
            }

            return enjektors;
        }

        public Kisim GetKisim(int kisimId)
        {
            if (!_kisimRepository.KisimExist(kisimId))
            {
                throw new Exception("There is no kisim with id: " + kisimId);
            }

            var kisim = _kisimRepository.GetKisim(kisimId);

            if (_rules.IsNull(kisim))
            {
                throw new Exception("There is no such kisim");
            }

            return kisim;
        }

        public ICollection<Kisim> GetKisims()
        {
            var kisims = _kisimRepository.GetKisims();

            if (_rules.IsNull(kisims))
            {
                throw new Exception("There is no kisim");
            }

            return kisims;
        }
    }
}
