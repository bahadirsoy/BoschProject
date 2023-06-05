using BoschApp.BusinessLayer.Abstract;
using BoschApp.BusinessLayer.Rules;
using BoschApp.DataAccessLayer.Abstract;
using BoschApp.EntityLayer.Entities.SiparisEntity;
using BoschApp.EntityLayer.Entities.StokAlaniEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschApp.BusinessLayer.Concrete
{
    public class StokAlaniBusinessService : IStokAlaniBusinessService
    {
        private readonly IStokAlaniRepository _stokAlaniRepository;
        private readonly BusinessRules _rules;

        public StokAlaniBusinessService(IStokAlaniRepository stokAlaniRepository, BusinessRules rules)
        {
            _stokAlaniRepository = stokAlaniRepository;
            _rules = rules;
        }

        public StokAlani GetStokAlani(int stokAlaniId)
        {
            var stokAlani = _stokAlaniRepository.GetStokAlani(stokAlaniId);

            if (_rules.IsNull(stokAlani))
            {
                throw new Exception("There is no stok alani with id: " + stokAlaniId);
            }

            return stokAlani;
        }

        public ICollection<StokAlani> GetStokAlanis()
        {
            var stokAlanis = _stokAlaniRepository.GetStokAlanis();

            if (_rules.IsNull(stokAlanis))
            {
                throw new Exception("There is no stok alani");
            }

            return stokAlanis;
        }

        public bool UpdateStokAlani(StokAlani stokAlani, int stokAlaniId)
        {
            if (_rules.IsNull(stokAlani))
            {
                throw new Exception("There is no stokAlani to be updated");
            }

            if(stokAlaniId != stokAlani.Id)
            {
                throw new Exception("stokAlani IDs do not match" + stokAlani.Id + " and " + stokAlaniId);
            }

            if (!_stokAlaniRepository.StokAlaniExist(stokAlaniId))
            {
                throw new Exception("There is no stokAlani with id: " + stokAlaniId);
            }

            return _stokAlaniRepository.UpdateStokAlani(stokAlani);
        }
    }
}
