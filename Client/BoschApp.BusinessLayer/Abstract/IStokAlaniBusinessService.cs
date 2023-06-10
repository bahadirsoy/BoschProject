using BoschApp.EntityLayer.Entities.StokAlaniEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschApp.BusinessLayer.Abstract
{
    public interface IStokAlaniBusinessService
    {
        ICollection<StokAlani> GetStokAlanis();
        StokAlani GetStokAlani(int stokAlaniId);
        bool UpdateStokAlani(StokAlani stokAlani, int stokAlaniId);
    }
}
