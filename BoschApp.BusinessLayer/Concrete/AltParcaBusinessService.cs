using BoschApp.BusinessLayer.Abstract;
using BoschApp.BusinessLayer.Rules;
using BoschApp.DataAccessLayer.Abstract;
using BoschApp.EntityLayer.Entities.AltParcaEntity;
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
            throw new NotImplementedException();
        }

        public ICollection<AltParca> GetAltParcas()
        {
            throw new NotImplementedException();
        }

        public Istasyon GetIstasyonByAltParca(int altParcaId)
        {
            throw new NotImplementedException();
        }

        public StokAlani GetStokAlaniByAltParca(int altParcaId)
        {
            throw new NotImplementedException();
        }
    }
}
