using BoschApp.EntityLayer.Entities.StokAlaniEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschApp.DataAccessLayer.Abstract
{
    public interface IStokAlaniRepository
    {
        ICollection<StokAlani> GetStokAlanis();
        bool StokAlaniExist(int stokAlaniId);
        StokAlani GetStokAlani(int stokAlaniId);
        bool UpdateStokAlani(StokAlani stokAlani);
        bool Save();
    }
}
