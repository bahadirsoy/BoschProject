using BoschApp.BusinessLayer.Abstract;
using BoschApp.BusinessLayer.Rules;
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
        private readonly IStokAlaniBusinessService _stokAlaniBusinessService;
        private readonly BusinessRules _rules;

        public StokAlaniBusinessService(IStokAlaniBusinessService stokAlaniBusinessService, BusinessRules rules)
        {
            _stokAlaniBusinessService = stokAlaniBusinessService;
            _rules = rules;
        }

        public StokAlani GetStokAlani(int stokAlaniId)
        {
            throw new NotImplementedException();
        }

        public ICollection<StokAlani> GetStokAlanis()
        {
            var stokAlanis = _stokAlaniBusinessService.GetStokAlanis();

            if (_rules.IsNull(stokAlanis))
            {
                throw new Exception("There is no stok alani");
            }

            return stokAlanis;
        }
    }
}
