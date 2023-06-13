using BoschApp.BusinessLayer.Abstract;
using BoschApp.BusinessLayer.Rules;
using BoschApp.DataAccessLayer.Abstract;
using BoschApp.EntityLayer.Entities.AltParcaEntity;
using BoschApp.EntityLayer.Entities.IstasyonEntity;
using BoschApp.EntityLayer.Entities.KisimEntity;
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

        public ICollection<AltParca> GetAltParcasAndStokAlaniByIstasyon(int istasyonId)
        {
            if (!_istasyonRepository.IstasyonExist(istasyonId))
            {
                throw new Exception("There is no istasyon with id: " + istasyonId);
            }

            var altParcasAndStokAlani = _istasyonRepository.GetAltParcasAndStokAlaniByIstasyon(istasyonId);

            if (_rules.IsNull(altParcasAndStokAlani))
            {
                throw new Exception("This istasyon has no altParca");
            }

            return altParcasAndStokAlani;
        }

        public ICollection<AltParca> GetAltParcasByIstasyon(int istasyonId)
        {
            if (!_istasyonRepository.IstasyonExist(istasyonId))
            {
                throw new Exception("There is no istasyon with id: " + istasyonId);
            }

            var altParcas = _istasyonRepository.GetAltParcasByIstasyon(istasyonId);

            if (_rules.IsNull(altParcas))
            {
                throw new Exception("This istasyon has no altParca");
            }

            return altParcas;
        }

        public Istasyon GetIstasyon(int istasyonId)
        {
            if (!_istasyonRepository.IstasyonExist(istasyonId))
            {
                throw new Exception("There is no istasyon with id: " + istasyonId);
            }

            var istasyon = _istasyonRepository.GetIstasyon(istasyonId);

            if (_rules.IsNull(istasyon))
            {
                throw new Exception("There is no such istasyon");
            }

            return istasyon;
        }

        public ICollection<Istasyon> GetIstasyons()
        {
            var istasyons = _istasyonRepository.GetIstasyons();

            if (_rules.IsNull(istasyons))
            {
                throw new Exception("There is no istasyon");
            }

            return istasyons;
        }
    }
}
