using BoschApp.BusinessLayer.Abstract;
using BoschApp.BusinessLayer.Rules;
using BoschApp.DataAccessLayer.Abstract;
using BoschApp.EntityLayer.Entities.AltParcaEntity;
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
    public class EnjektorBusinessService : IEnjektorBusinessService
    {
        private readonly IEnjektorRepository _enjektorRepository;
        private readonly BusinessRules _rules;

        public EnjektorBusinessService(IEnjektorRepository enjektorRepository, BusinessRules rules)
        {
            _enjektorRepository = enjektorRepository;
            _rules = rules;
        }

        public AltParca GetAltParcaByEnjektorAndIstasyon(int enjektorId, int istasyonId)
        {
            if (!_enjektorRepository.EnjektorExist(enjektorId))
            {
                throw new Exception("There is no enjektor with id: " + enjektorId);
            }

            var altParca = _enjektorRepository.GetAltParcaByEnjektorAndIstasyon(enjektorId, istasyonId);

            if (_rules.IsNull(altParca))
            {
                throw new Exception("This enjektor has no altParca");
            }

            return altParca;
        }

        public ICollection<AltParca> GetAltParcasByEnjektor(int enjektorId)
        {
            if (!_enjektorRepository.EnjektorExist(enjektorId))
            {
                throw new Exception("There is no enjektor with id: " + enjektorId);
            }

            var altParcas = _enjektorRepository.GetAltParcasByEnjektor(enjektorId);

            if (_rules.IsNull(altParcas))
            {
                throw new Exception("This enjektor has no altParca");
            }

            return altParcas;
        }

        public Enjektor GetEnjektor(int enjektorId)
        {
            if (!_enjektorRepository.EnjektorExist(enjektorId))
            {
                throw new Exception("There is no enjektor with id: " + enjektorId);
            }

            var enjektor = _enjektorRepository.GetEnjektor(enjektorId);

            if (_rules.IsNull(enjektor))
            {
                throw new Exception("There is no such enjektor");
            }

            return enjektor;
        }

        public ICollection<Enjektor> GetEnjektors()
        {
            var enjektors = _enjektorRepository.GetEnjektors();

            if (_rules.IsNull(enjektors))
            {
                throw new Exception("There is no enjektor");
            }

            return enjektors;
        }

        public Kisim GetKisimByEnjektor(int enjektorId)
        {
            if (!_enjektorRepository.EnjektorExist(enjektorId))
            {
                throw new Exception("This enjektor has no Kisim");
            }

            var kisim = _enjektorRepository.GetKisimByEnjektor(enjektorId);

            if (_rules.IsNull(kisim))
            {
                throw new Exception("There is no Kisim");
            }

            return kisim;
        }
    }
}
