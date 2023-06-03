using BoschApp.DataAccessLayer.Abstract;
using BoschApp.DataAccessLayer.Data;
using BoschApp.EntityLayer.Entities.StokAlaniEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschApp.DataAccessLayer.Concrete
{
    public class StokAlaniRepository : IStokAlaniRepository
    {
        private readonly DataContext _context;

        public StokAlaniRepository(DataContext context)
        {
            _context = context;
        }

        public StokAlani GetStokAlani(int stokAlaniId)
        {
            throw new NotImplementedException();
        }

        public ICollection<StokAlani> GetStokAlanis()
        {
            throw new NotImplementedException();
        }

        public bool StokAlaniExist(int stokAlaniId)
        {
            throw new NotImplementedException();
        }
    }
}
