using BoschApp.BusinessLayer.Abstract;
using BoschApp.BusinessLayer.Rules;
using BoschApp.DataAccessLayer.Abstract;
using BoschApp.EntityLayer.Entities.AltParcaEntity;
using BoschApp.EntityLayer.Entities.DepartmanEntityEntity;
using BoschApp.EntityLayer.Entities.SiparisEntity;
using BoschApp.EntityLayer.Entities.UretimEntity;
using BoschApp.EntityLayer.Entities.StokAlaniEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschApp.BusinessLayer.Concrete
{
    public class UretimBusinessService : IUretimBusinessService
    {
        private readonly IUretimRepository _uretimRepository;
        private readonly ISiparisRepository _siparisRepository;
        private readonly IAltParcaRepository _altParcaRepository;
        private readonly IStokAlaniRepository _stokAlaniRepository;
        private readonly BusinessRules _rules;

        public UretimBusinessService(
            IUretimRepository uretimRepository,
            ISiparisRepository siparisRepository,
            IAltParcaRepository altParcaRepository,
            IStokAlaniRepository stokAlaniRepository,
            BusinessRules rules)
        {
            _uretimRepository = uretimRepository;
            _siparisRepository = siparisRepository;
            _altParcaRepository = altParcaRepository;
            _stokAlaniRepository = stokAlaniRepository;
            _rules = rules;
        }

        public bool CreateUretim(Uretim uretim, int siparisId, int altParcaId)
        {
            if (_rules.IsNull(uretim))
            {
                throw new Exception("There is no uretim to be created");
            }

            var siparis = _siparisRepository.GetSiparis(siparisId);
            var stokAlani = _altParcaRepository.GetStokAlaniByAltParca(altParcaId);

            if(stokAlani.StokAdeti < siparis.Adet)
            {
                throw new Exception("There is not enough altParca for this siparis");
            }

            stokAlani.StokAdeti -= _siparisRepository.GetSiparis(siparisId).Adet;

            _stokAlaniRepository.UpdateStokAlani(stokAlani);
            return _uretimRepository.CreateUretim(uretim);
        }

        public bool DeleteUretim(Uretim uretim, int uretimId)
        {
            if (!_uretimRepository.UretimExist(uretimId))
            {
                throw new Exception("There is no uretim with id: " + uretimId);
            }

            if (_rules.IsNull(uretim))
            {
                throw new Exception("There is no uretim to be deleted");
            }

            return _uretimRepository.DeleteUretim(uretim);
        }

        public AltParca GetAltParcaByUretim(int uretimId)
        {
            if (!_uretimRepository.UretimExist(uretimId))
            {
                throw new Exception("There is no uretim with id: " + uretimId);
            }

            var altParca = _uretimRepository.GetAltParcaByUretim(uretimId);

            if (_rules.IsNull(altParca))
            {
                throw new Exception("This uretim has no altParca");
            }

            return altParca;
        }

        public Siparis GetSiparisByUretim(int uretimId)
        {
            if (!_uretimRepository.UretimExist(uretimId))
            {
                throw new Exception("There is no uretim with id: " + uretimId);
            }

            var siparis = _uretimRepository.GetSiparisByUretim(uretimId);

            if (_rules.IsNull(siparis))
            {
                throw new Exception("This uretim has no siparis");
            }

            return siparis;
        }

        public Uretim GetUretim(int uretimId)
        {
            if (!_uretimRepository.UretimExist(uretimId))
            {
                throw new Exception("There is no uretim with id: " + uretimId);
            }

            var uretim = _uretimRepository.GetUretim(uretimId);

            if (_rules.IsNull(uretim))
            {
                throw new Exception("There is no such uretim");
            }

            return uretim;
        }

        public bool IsProduced(int siparisId, int altParcaId)
        {
            return _uretimRepository.IsProduced(siparisId, altParcaId);
        }
    }
}
