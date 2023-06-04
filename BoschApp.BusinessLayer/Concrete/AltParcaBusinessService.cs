using BoschApp.BusinessLayer.Abstract;
using BoschApp.BusinessLayer.Rules;
using BoschApp.DataAccessLayer.Abstract;
using BoschApp.EntityLayer.Entities.AltParcaEntity;
using BoschApp.EntityLayer.Entities.DepartmanEntityEntity;
using BoschApp.EntityLayer.Entities.IstasyonEntity;
using BoschApp.EntityLayer.Entities.StokAlaniEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschApp.BusinessLayer.Concrete
{
    public class AltParcaBusinessService : IAltParcaBusinessService
    {
        private readonly IAltParcaRepository _altParcaRepository;
        private readonly BusinessRules _rules;

        public AltParcaBusinessService(IAltParcaRepository altParcaRepository, BusinessRules rules)
        {
            _altParcaRepository = altParcaRepository;
            _rules = rules;
        }

        public AltParca GetAltParca(int altParcaId)
        {
            if(!_altParcaRepository.AltParcaExist(altParcaId))
            {
                throw new Exception("There is no altParca with id: " + altParcaId);
            }

            var altParca = _altParcaRepository.GetAltParca(altParcaId);

            if (_rules.IsNull(altParca))
            {
                throw new Exception("There is no such altParca");
            }

            return altParca;
        }

        public ICollection<AltParca> GetAltParcas()
        {
            var altParcas = _altParcaRepository.GetAltParcas();

            if (_rules.IsNull(altParcas))
            {
                throw new Exception("There is no altParca");
            }

            return altParcas;
        }

        public Istasyon GetIstasyonByAltParca(int altParcaId)
        {
            if (_altParcaRepository.AltParcaExist(altParcaId))
            {
                throw new Exception("There is no Istasyon belonging to this altParca with id: " + altParcaId);
            }

            var istasyon = _altParcaRepository.GetIstasyonByAltParca(altParcaId);

            if (_rules.IsNull(istasyon))
            {
                throw new Exception("There is no such istasyon")
            }

            return istasyon;
        }

        public StokAlani GetStokAlaniByAltParca(int altParcaId)
        {
            if (_altParcaRepository.AltParcaExist(altParcaId))
            {
                throw new Exception("There is no stokAlani belonging to this altParca with id: " + altParcaId);
            }

            var stokAlani = _altParcaRepository.GetStokAlaniByAltParca(altParcaId);

            if (_rules.IsNull(stokAlani))
            {
                throw new Exception("There is no stokAlani");
            }

            return stokAlani;
        }
    }
}
